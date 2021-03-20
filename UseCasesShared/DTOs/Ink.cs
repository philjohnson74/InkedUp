using System;
using UseCasesShared.Interfaces.DTOs;

namespace UseCasesShared.DTOs
{
    public class Ink : IInk
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Colour { get; set; }
    }
}
