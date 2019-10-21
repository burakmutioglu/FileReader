using System;
using System.IO;
using CsvReader.Common.Dto;
using CsvReader.Common.Mapper;
using Microsoft.AspNetCore.Http;
using CsvReader.Core.Services.Interfaces;

namespace CsvReader.Core.Services.Internal
{
    public class CsvReaderService : ICsvReaderService
    {
        public UploadResult FileUpload(IFormFile file)
        {
            string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);

            UploadResult uResult = new UploadResult();

            if (Directory.Exists(uploadPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(uploadPath);

                if (di.Name == null)
                {
                    uResult.Error = "Folder create failed";
                    return uResult;
                }
            }


            try
            {
                using (var stream = new FileStream(uploadPath, FileMode.Create))
                    file.CopyTo(stream);

                uResult.IsUploaded = true;
                uResult.FileName = file.FileName;
                uResult.FilePath = uploadPath;
            }
            catch (Exception ex)
            {
                uResult.IsUploaded = false;
                uResult.Error = $"File upload failed: {ex.Message}";
            }

            return uResult;
        }

        public ServiceResult<HotelDto> ReadCsv(string filePath)
        {
            try
            {
                ServiceResult<HotelDto> serviceResult = new ServiceResult<HotelDto>();

                var reader = new StreamReader(filePath);
                var csv = new CsvHelper.CsvReader(reader);

                csv.Read();
                csv.ReadHeader();
                csv.Configuration.Delimiter = ",";
                csv.Configuration.RegisterClassMap<HotelMapping>();

                serviceResult.Records = csv.GetRecords<HotelDto>();

                return serviceResult;

            }
            catch (Exception ex)
            {
                return ServiceResult<HotelDto>.SetFailed(ex.Message);
            }
        }
    }
}




