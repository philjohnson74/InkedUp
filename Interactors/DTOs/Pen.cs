using System;
namespace Interactors.DTOs
{
    public class Pen : IPen
    {
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public IInk Ink { get; set; }
    }
}
