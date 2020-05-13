using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1.FileExtensions
{
    public static class FileExtensions
    {
        public const string TransportType = "TransportType";

        public const string TrolleybusType = "TrolleybusType";

        public static IList<Transport> GetTransports(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
                {
                    csv.Configuration.IgnoreBlankLines = false;

                    csv.Configuration.RegisterClassMap<CollectionMapTransport>();
                    csv.Configuration.RegisterClassMap<CollectionMapTrolleybusType>();

                    var transportRecord = new List<Transport>();
                    bool isHeader = true;

                    while (csv.Read())
                    {
                        if (isHeader)
                        {
                            csv.ReadHeader();
                            isHeader = false;
                            continue;
                        }

                        if (string.IsNullOrEmpty(csv.GetField(0)))
                        {
                            isHeader = true;
                            continue;
                        }

                        switch (csv.Context.HeaderRecord[0])
                        {
                            case TransportType:
                                transportRecord.Add(csv.GetRecord<Transport>());
                                break;
                            case TrolleybusType:
                                transportRecord.Add(csv.GetRecord<Trolleybus>());
                                break;
                            default:
                                throw new InvalidOperationException("Unknown record type.");
                        }
                    }

                    return transportRecord;
                }
            }
        }

        public static void SetProducts(IReadOnlyCollection<Transport> transports, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
                {
                    csv.WriteRecords(transports);
                }
            }
        }
    }
}
