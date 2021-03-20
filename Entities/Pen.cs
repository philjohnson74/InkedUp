using System;

namespace Entities
{
    public class Pen
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public Ink Ink { get; set; }

        public void InkUp(Ink ink)
        {
            Ink = ink;
        }
    }
}
