using System;

namespace CsvReader.Common.Results
{
    public class UploadResult
    {
        public UploadResult()
        {
            FileKey = Guid.NewGuid().ToString("n");
        }
        public UploadResult(bool isUploaded, string fileName)
        {
            IsUploaded = isUploaded;
            FileName = fileName;
            FileKey = Guid.NewGuid().ToString("n");
        }

        public bool IsUploaded { get; set; }
        public string FileName { get; set; }
        public string Error { get; set; }
        public string FilePath { get; set; }
        public string FileKey { get; }
    }
}
