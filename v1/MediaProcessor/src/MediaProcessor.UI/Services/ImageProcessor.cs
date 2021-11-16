using ExifLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaProcessor.UI.Model;

namespace MediaProcessor.UI.Services
{
    internal class ImageProcessor : MediaFileProcessorBase
    {

        public ImageProcessor() : base(new[] { ".jpg", ".jpeg", ".bmp", ".gif", ".png", ".dng" }) { }

        public override void SetOriginalDate(string caminho, DateTime data)
        {

            var imageFile = ImageFile.FromFile(caminho);

            var property = imageFile.Properties.FirstOrDefault(p => p.Tag == ExifTag.DateTimeOriginal);

            if (property == null)
            {
                imageFile.Properties.Add(ExifTag.DateTimeOriginal, data);
            }
            else
            {
                property.Value = data;
            }

            imageFile.Save(caminho);

            File.SetCreationTime(caminho, data);

            File.SetLastWriteTime(caminho, data);

        }

        protected DateTime? ExtractDateFromImageFile(FileInfo origem)
        {

            var imageFile = ImageFile.FromFile(origem.FullName);

            var property = imageFile.Properties.FirstOrDefault(p => p.Tag == ExifTag.DateTimeOriginal);

            return property == null || property.Value == null
                        ? null
                        : property.Value as DateTime?;

        }

        public override DateTime ObterData(FileInfo origem)
        {

            var resultado = origem.Extension == "png" ? default(DateTime?) : ExtractDateFromImageFile(origem);

            if (resultado.HasValue && resultado.Value > DateTime.MinValue) return resultado.Value;

            resultado = ExtractDateFromFileName(origem);

            if (resultado.HasValue && resultado.Value > DateTime.MinValue) return resultado.Value;

            return ExtractDateFromFile(origem);

        }

        public override MediaFileProcessorResponse Processar(FileInfo origem, string destino, bool ignorarSeJaExistirNoDestino = false)
        {
            try
            {

                var log = new StringBuilder("O processamento do arquivo de origem");

                var dataArquivo = ObterData(origem);

                var nomeArquivo = $"{dataArquivo:yyyyMMdd_HHmmss}{origem.Extension.ToLower()}";

                var caminhoCompleto = $"{destino}\\{nomeArquivo}";

                if (ignorarSeJaExistirNoDestino && File.Exists(caminhoCompleto))
                {

                    log.Append(" ignorado, pois já existe no destino.");

                    return new MediaFileProcessorResponse(true, log.ToString());

                }

                CopyFileToTargetPath(origem, caminhoCompleto);

                SetOriginalDate(caminhoCompleto, dataArquivo);

                log.Append(" executado e o arquivo resultante foi copiada com sucesso para o destino.");

                return new MediaFileProcessorResponse(true, log.ToString());

            }
            catch (Exception ex)
            {

                var log = new StringBuilder($@"Falha ao processar o arquivo de origem '{origem.FullName}' com destino '{destino}': {ex.Message}");

                if (!ex.Message.EndsWith("."))
                {
                    log.Append(".");
                }

                return new MediaFileProcessorResponse(false, log.ToString());

            }
        }

    }
}