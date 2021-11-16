namespace MediaProcessor.UI.Model
{
    public class MediaFileProcessorResponse
    {

        public bool Success { get; }

        public string Message { get; }

        public MediaFileProcessorResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }

    }
}
