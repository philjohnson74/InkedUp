namespace Interactors.DTOs
{
    public class Ink : IInk
    {
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public string Colour { get; set; }

        public string DisplayName => $"{Manufacturer} - {Colour}";
    }
}
