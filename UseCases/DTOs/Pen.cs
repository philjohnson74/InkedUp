using System;
namespace UseCases.DTOs
{
    public class Pen
    {
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public Ink Ink { get; set; }
    }
}
