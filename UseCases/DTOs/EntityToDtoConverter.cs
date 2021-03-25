using System;
using UseCasesShared.Interfaces.DTOs;

namespace UseCases.DTOs
{
    public static class DtoToEntityConverter
    {
        public static Entities.Pen Convert(IPen pen)
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

        public static Entities.Ink Convert(IInk ink)
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
