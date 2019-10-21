using System.Collections.Generic;

namespace CsvReader.Common.Results
{
    public class ReaderResult<T>
    {
        public static ReaderResult<T> SetFailed()
        {
            return new ReaderResult<T> { IsReaded = false };
        }
        public static ReaderResult<T> SetRecords(IEnumerable<T> records)
        {
            return new ReaderResult<T> { IsReaded = true, Records = records };
        }

        public IEnumerable<T> Records { get; set; }
        public bool IsReaded { get; set; }
    }
}
