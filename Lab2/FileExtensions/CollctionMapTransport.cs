using CsvHelper.Configuration;

namespace Task1.FileExtensions
{
    public class CollectionMapTransport : ClassMap<Transport>
    {
        public CollectionMapTransport()
        {
            Map(m => m.Type).Name(FileExtensions.TransportType);
            Map(m => m.ReleaseYear).Name(nameof(Transport.ReleaseYear));
            Map(m => m.RegistrationNumber).Name(nameof(Transport.RegistrationNumber));
        }
    }
}
