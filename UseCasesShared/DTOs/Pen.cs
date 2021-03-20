using System;
using UseCasesShared.Interfaces.DTOs;

namespace UseCasesShared.DTOs
{
    public class Pen : IPen
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public IInk Ink { get; set; }
    }
}
