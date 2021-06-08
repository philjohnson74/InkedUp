namespace Adapters.DTOs
{
    public class Pen
    {
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Ink Ink { get; set; }

        public string DisplayName => $"{Manufacturer} - {Model}";

        public string DisplayNameWithInk => SuffixInkDisplayName(DisplayName);

        private string SuffixInkDisplayName(string displayName)
        {
            if (Ink != null)
                displayName = $"{displayName} ({Ink.DisplayName})";
            return displayName;
        }
    }
}
