using System;
using UseCasesShared.DTOs;

namespace UseCases.DTOs
{
    public static class DtoToEntityConverter
    {
        public static Entities.Pen Convert(Pen pen)
        {
            Entities.Pen penEntity = new Entities.Pen()
            {
                Id = pen.Id,
                Manufacturer = pen.Manufacturer,
                Model = pen.Model
            };

            if (pen.Ink != null)
                penEntity.Ink = Convert(pen.Ink);

            return penEntity;
        }

        public static Entities.Ink Convert(Ink ink)
        {
            Entities.Ink inkEntity = new Entities.Ink()
            {
                Id = ink.Id,
                Manufacturer = ink.Manufacturer,
                Colour = ink.Colour
            };

            return inkEntity;
        }
    }
}
