using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class TransportCollection<T> where T : Transport
    {
        public TransportCollection(IList<T> transports)
        {
            Transports = transports.ToList();
        }

        public List<T> Transports { get; }

        public void Add(T transport) => Transports.Add(transport);

        public void Remove(T transport) => Transports.Remove(transport);

        public void Sort()
        {
            Transports.OrderBy(obj => obj).ToList();
        }

        public ArrayList GetTrolleybus(int milleage, int routeNumber)
        {
            var list = new ArrayList();

            foreach (object transport in Transports)
            {
                if (transport.GetType() == typeof(Trolleybus))
                {
                    if (((Trolleybus)transport).Mileage <= milleage && ((Trolleybus)transport).RouteNumber == routeNumber)
                    {
                        list.Add(transport);
                    }
                }
            }

            return list;
        }
    }
}
