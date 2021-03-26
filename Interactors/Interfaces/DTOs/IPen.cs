namespace Interactors.DTOs
{
    public interface IPen
    {
        string Id { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        IInk Ink { get; set; }
        string DisplayName { get; }
        string DisplayNameWithInk { get; }
    }
}