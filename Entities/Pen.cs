using System;

namespace Entities
{
    public class Pen
    {
        public string PenId { get; set; }
        public string Manufacturer { get; set; }
        public Ink Ink { get; set; }

        public void InkUp(Ink ink)
        {
            Ink = ink;
        }
    }
}
