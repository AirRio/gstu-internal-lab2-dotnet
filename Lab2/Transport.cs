using System;

namespace Task1
{
    public class Transport : IComparable<Transport>
    {
        public Transport()
        {  }

        public string Type { get; set; }

        public int ReleaseYear { get; set; }

        public string RegistrationNumber { get; set; }

        public int CompareTo(Transport transport)
        {
            return Type.CompareTo(transport.Type);
        }

        public override string ToString() => ($"{Type}\t{ReleaseYear}\t{RegistrationNumber}");
    }
}
