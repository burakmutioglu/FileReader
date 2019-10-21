using CsvReader.Common.Dto;
using CsvReader.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CsvReader.Core.Services.Interfaces;

namespace CsvReader.Controllers
{
    public class CsvReaderController : Controller
    {
        private readonly ICsvReaderService _csvReaderService;

        public CsvReaderController(ICsvReaderService csvReaderService)
        {
            _csvReaderService = csvReaderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult DataTable(IFormFile file)
        {
            var uResult = _csvReaderService.FileUpload(file);
            ServiceResult<HotelDto> serviceResult = new ServiceResult<HotelDto>();

            if (uResult.IsUploaded)
            {
                serviceResult = _csvReaderService.ReadCsv(uResult.FilePath);              
            }
            else
            {
                ModelState.AddModelError("", uResult.Error);
            }

            return View(serviceResult.Records);
        }
    }
}