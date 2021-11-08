using MediaProcessor.UI.Model;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.IO;
using System.Text;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaProcessor.UI.Services
{
    internal class VideoProcessor : MediaFileProcessorBase
    {


        private readonly string[] _letras = { "", "B", "C", "D", "E", "F", "G" };

        public VideoProcessor() : base(new[] { ".mpeg", ".wma", ".mp4", ".mpg", ".avi", ".m4v", "*.mov" }) { }

        public override MediaFileProcessorResponse Processar(FileInfo sourceFile, string targetPath, bool ignorarSeJaExistirNoDestino = false)
        {

            var log = new StringBuilder(@"O processamento do arquivo de origem");

            try
            {

                var targetDate = ObterData(sourceFile);

                var identificadorDuplicidade = 0;
                var tentarNovamente = false;

                var targetFilePathName = string.Empty;

                var arquivoFoiCopiado = false;

                do
                {

                    tentarNovamente = false;

                    try
                    {

                        var targetFileName = FormarNomeArquivo(targetDate, identificadorDuplicidade, sourceFile.Extension);

                        targetFilePathName = $"{targetPath}\\{targetFileName}";

                        if (ignorarSeJaExistirNoDestino && File.Exists(targetFilePathName))
                        {
                            log.Append(" ignorado, pois já existe no destino.");
                        }
                        else
                        {
                            CopyFileToTargetPath(sourceFile, targetFilePathName);
                            arquivoFoiCopiado = true;
                        }


                    }
                    catch (Exception e) when (e.Message.Contains("already exists"))
                    {
                        tentarNovamente = true;
                        identificadorDuplicidade++;
                    }


                } while (tentarNovamente);


                if (arquivoFoiCopiado)
                {

                    SetOriginalDate(targetFilePathName, targetDate);

                    log.Append(" executado e o arquivo resultante foi copiada com sucesso para o destino.");

                }

                return new MediaFileProcessorResponse(true, log.ToString());

            }
            catch (Exception ex)
            {

                log.Append($" teve uma falha: {ex.Message}");

                if (!ex.Message.EndsWith("."))
                {
                    log.Append(".");
                }

                return new MediaFileProcessorResponse(false, log.ToString());

            }

        }

        private string FormarNomeArquivo(DateTime data, int identificadorDuplicidade, string extensao)
        {
            return $"{data:yyyyMMdd_HHmmss}{_letras[identificadorDuplicidade]}{extensao}";
        }

        public override DateTime ObterData(FileInfo arquivo)
        {

            var targetDate = ObterDataPelaMetadata(arquivo) ?? default(DateTime?);

            if (!targetDate.HasValue || targetDate.Value == DateTime.MinValue)
            {
                targetDate = ExtractDateFromFileName(arquivo);
            }

            if (!targetDate.HasValue || targetDate.Value == DateTime.MinValue)
            {
                targetDate = ExtractDateFromFile(arquivo);
            }

            return targetDate.Value;

        }

        private DateTime? ObterDataPelaMetadata(FileInfo arquivo)
        {

            var arquivoVideo = ShellFile.FromFilePath(arquivo.FullName);

            return arquivoVideo == null
                    ? default(DateTime?)
                    : arquivoVideo.Properties.System.DateAcquired?.Value;
        }

        public override void SetOriginalDate(string caminho, DateTime data)
        {


            var arquivo = ShellFile.FromFilePath(caminho);

            using var pw = arquivo.Properties.GetPropertyWriter();

            var property = arquivo.Properties.System.ItemDate;

            if (property != null && property.Value != null) // se o valor for nulo, não é possível setar a propriedade :(
            {
                if (!property.Value.HasValue && property.Value.Value != data)
                {
                    property.Value = data;
                    pw.WriteProperty(property, data);
                    pw.WriteProperty(arquivo.Properties.System.ItemDate, data);
                }
            }
            else
            {
               
            }

            pw.Close();

            File.SetCreationTime(caminho, data);

            File.SetLastWriteTime(caminho, data);

        }

    }
}