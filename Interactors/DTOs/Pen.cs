namespace Interactors.DTOs
{
    public class Pen : IPen
    {
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public IInk Ink { get; set; }

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
