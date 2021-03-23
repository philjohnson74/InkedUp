using System;
namespace Interactors.DTOs
{
    public class Pen : IPen
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public IInk Ink { get; set; }

        public string DisplayName => $"{Manufacturer} - {Model}";
    }
}
