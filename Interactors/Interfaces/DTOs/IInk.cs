namespace Interactors.DTOs
{
    public interface IInk
    {
        string Id { get; set; }
        string Manufacturer { get; set; }
        string Colour { get; set; }
        string DisplayName { get; }
    }
}