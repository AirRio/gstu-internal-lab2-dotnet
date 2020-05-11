using CsvHelper.Configuration;

namespace Task1.FileExtensions
{
    public class CollectionMapTrolleybusType : ClassMap<Trolleybus>
    {
        public CollectionMapTrolleybusType()
        {
            Map(m => m.Type).Name(FileExtensions.TrolleybusType);
            Map(m => m.ReleaseYear).Name(nameof(Trolleybus.ReleaseYear));
            Map(m => m.RegistrationNumber).Name(nameof(Trolleybus.RegistrationNumber));
            Map(m => m.RouteNumber).Name(nameof(Trolleybus.RouteNumber));
            Map(m => m.Mileage).Name(nameof(Trolleybus.Mileage));
        }
    }
}
