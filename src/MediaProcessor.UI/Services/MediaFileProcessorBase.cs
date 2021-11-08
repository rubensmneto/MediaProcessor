using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MediaProcessor.UI.Model;

namespace MediaProcessor.UI.Services
{
    internal abstract class MediaFileProcessorBase : Core.IMediaFileProcessor
    {

        protected readonly string[] ValidExtensions;

        protected MediaFileProcessorBase(string[] validExtensions)
        {
            ValidExtensions = validExtensions;
        }

        protected DateTime? ExtractDateFromFileName(FileInfo sourceFile)
        {

            string fileName = sourceFile.Name.Split('.')[0];

            if (fileName.IndexOf("_") < 0)
            {
                return null;
            }

            DateTime result = DateTime.MinValue;

            string[] fileNameSplitted = fileName.Split('_');

            int datePart, hourPart;

            if (fileNameSplitted.Length == 2 && (fileNameSplitted[0].Length == 7 || fileNameSplitted[0].Length == 8) && (fileNameSplitted[1].Length >= 3 && fileNameSplitted[1].Length <= 6) && int.TryParse(fileNameSplitted[0], out datePart) && int.TryParse(fileNameSplitted[1], out hourPart))
            {
                string datePartString = $"{fileNameSplitted[0].Substring(0, 4)}-{fileNameSplitted[0].Substring(4, 2)}-{fileNameSplitted[0].Substring(6, 2)}";
                string hourPartString = $"{fileNameSplitted[1].Substring(0, 2)}:{fileNameSplitted[1].Substring(2, 2)}:{fileNameSplitted[1].Substring(4, 2)}";
                DateTime.TryParseExact(datePartString + " " + hourPartString, "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out result);
            }

            return result;

        }

        protected DateTime ExtractDateFromFile(FileInfo sourceFile)
        {
            return sourceFile.LastWriteTime < sourceFile.CreationTime ? sourceFile.LastWriteTime : sourceFile.CreationTime;
        }

        public bool ServiceLocation(string extension)
        {

            if (!extension.StartsWith("."))
            {
                extension = $".{extension}";
            }

            return ValidExtensions.Any(x => extension.Equals(x, StringComparison.InvariantCultureIgnoreCase));

        }

        protected void GenerateTargetPath(string targetPath)
        {

            var targetSplitted = targetPath.Split('\\');

            var currentTarget = string.Empty;

            foreach (string part in targetSplitted)
            {

                if (string.IsNullOrEmpty(currentTarget))
                {
                    currentTarget = part;
                    continue;
                }

                if (part.Equals(targetSplitted.Last(), StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                currentTarget = $"{currentTarget}\\{part}";

                if (!Directory.Exists(currentTarget))
                {
                    Directory.CreateDirectory(currentTarget);
                }

            }

        }

        protected void CopyFileToTargetPath(FileInfo sourceFile, string targetPath)
        {

            GenerateTargetPath(targetPath);

            if (File.Exists(targetPath))
            {

                FileInfo targetFile = new FileInfo(targetPath);

                if (sourceFile.Length == targetFile.Length)
                {
                    var message = "Já existe um arquivo no destino com o mesmo nome e tamanho do arquivo de origem (são o mesmo arquivo?). Não será realizada a cópia.";
                    message += Environment.NewLine;
                    message += $"Origem: {sourceFile.FullName};" + Environment.NewLine;
                    message += $"Destino: {targetFile.FullName}.";
                    throw new Exception(message);
                }

            }

            sourceFile.CopyTo(targetPath);

        }

        public abstract MediaFileProcessorResponse Processar(FileInfo origem, string destino, bool ignorarSeJaExistirNoDestino = false);

        public abstract DateTime ObterData(FileInfo origem);

        public abstract void SetOriginalDate(string caminho, DateTime data);

    }
}