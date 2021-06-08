using System;
using UseCasesShared.DTOs;

namespace UseCases.DTOs
{
    public static class EntityToDtoConverter
    {
        public static Pen Convert(Entities.Pen penEntity)
        {
            Pen useCasePen = new Pen()
            {
                Id = penEntity.Id,
                Manufacturer = penEntity.Manufacturer,
                Model = penEntity.Model,
                Ink = Convert(penEntity.Ink)
            };

            return useCasePen;
        }

        public static Ink Convert(Entities.Ink inkEntity)
        {
            Ink useCaseInk = new Ink()
            {
                Id = inkEntity.Id,
                Manufacturer = inkEntity.Manufacturer,
                Colour = inkEntity.Colour
            };

            return useCaseInk;
        }
    }
}
