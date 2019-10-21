namespace CsvReader.Core.Services
{
    public class UploadResult
    {
        public UploadResult()
        {

        }
        public UploadResult(bool isUploaded, string fileName)
        {
            IsUploaded = isUploaded;
            FileName = fileName;            
        }

        public bool IsUploaded { get; set; }
        public string FileName { get; set; }
        public string Error { get; set; }
        public string FilePath { get; set; }
    }
}
