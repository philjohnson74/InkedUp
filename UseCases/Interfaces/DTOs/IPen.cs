namespace UseCases.DTOs
{
    public interface IPen
    {
        string Id { get; set; }
        string Manufacturer { get; set; }
        IInk Ink { get; set; }
    }
}