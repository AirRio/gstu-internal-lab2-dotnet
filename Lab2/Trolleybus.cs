namespace Task1
{
    public class Trolleybus : Transport
    {
        public Trolleybus() : base()
        {  }

        public int RouteNumber { get; set; }

        public int Mileage { get; set; }

        public override string ToString() => base.ToString() + "\t" + ($"{RouteNumber}\t{Mileage}");
    }
}
