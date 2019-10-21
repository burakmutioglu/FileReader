using System.Collections.Generic;

namespace CsvReader.Core.Services
{
    public class ServiceResult<T>
    {
        public ServiceResult()
        {

        }
        public static ServiceResult<T> SetFailed(string message)
        {
            return new ServiceResult<T> { ExceptionMessage = message };
        }
        public static ServiceResult<T> SetRecords(IEnumerable<T> records)
        {
            return new ServiceResult<T> {  Records = records };
        }

        public IEnumerable<T> Records { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
