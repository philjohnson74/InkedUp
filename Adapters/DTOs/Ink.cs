namespace Adapters.DTOs
{
    public class Ink
    {
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public string Colour { get; set; }

        public string DisplayName => $"{Manufacturer} - {Colour}";
    }
}
