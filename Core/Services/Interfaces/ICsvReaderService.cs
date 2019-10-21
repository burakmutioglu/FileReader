using CsvReader.Common.Dto;
using Microsoft.AspNetCore.Http;

namespace CsvReader.Core.Services.Interfaces
{
    public interface ICsvReaderService
    {
        UploadResult FileUpload(IFormFile file);
        ServiceResult<HotelDto> ReadCsv(string filePath);
    }
}
