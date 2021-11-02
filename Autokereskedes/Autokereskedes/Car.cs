namespace Autokereskedes
{
    public class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Doc { get; set; }
        public string Color { get; set; }
        public string LicenseNum { get; set; }

        public Car(string args)
        {
            string[] parts = args.Split(';');

            Name = parts[0];
            Type = parts[1];
            Doc = int.Parse(parts[2]);
            Color = parts[3];
            LicenseNum = parts[4];
        }
    }
}
