using CsvHelper.Configuration;
using CsvReader.Common.Dto;

namespace CsvReader.Common.Mapper
{
    public class HotelMapping : ClassMap<HotelDto>
    {
        public HotelMapping()
        {
            Map(m => m.Name).Index(0);
            Map(m => m.Address).Index(1);
            Map(m => m.Stars).Index(2);
            Map(m => m.Contact).Index(3);
            Map(m => m.Phone).Index(4);
            Map(m => m.Uri).Index(5);
        }
    }
}
