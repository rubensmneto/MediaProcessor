using MediaProcessor.UI.Model;
using System;
using System.IO;

namespace MediaProcessor.UI.Core
{
    public interface IMediaFileProcessor
    {

        bool ServiceLocation(string extension);

        MediaFileProcessorResponse Processar(FileInfo origem, string destino, bool ignorarSeJaExistirNoDestino = false);

        DateTime ObterData(FileInfo origem);

        void SetOriginalDate(string caminho, DateTime data);

    }
}