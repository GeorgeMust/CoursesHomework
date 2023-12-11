namespace ClassLibrary2
{
    public class Cone
    {
        public const double pi = Math.PI;

        public double Radius { get; set; }
        public double Height { get; set; }
        public Cone(
            double radius,
            double height)
        {
            Radius = radius;
            Height = height;
        }
        public double CalcSground()
        {
            return pi * Radius * Radius;
        }
        public double CalcSfull()
        {
            return pi * Radius * (Radius + Math.Sqrt(Radius * Radius + Height * Height));
        }
    }
}
