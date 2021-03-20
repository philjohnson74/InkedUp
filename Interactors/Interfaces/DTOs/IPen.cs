namespace Interactors.DTOs
{
    public interface IPen
    {
        int Id { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        IInk Ink { get; set; }
    }
}