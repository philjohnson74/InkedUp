using System;
namespace Interactors.DTOs
{
    public static class DtoToUseCaseDtoConverter
    {
        public static UseCasesShared.Interfaces.DTOs.IPen Convert(IPen pen)
        { 
            UseCasesShared.DTOs.Pen useCasePen = new UseCasesShared.DTOs.Pen()
            {
                Id = pen.Id,
                Manufacturer = pen.Manufacturer,
                Model = pen.Model,
                Ink = Convert(pen.Ink)
            };

            return useCasePen;
        }

        public static UseCasesShared.Interfaces.DTOs.IInk Convert(IInk ink)
        {
            UseCasesShared.DTOs.Ink useCaseInk = null;

            if (ink != null)
            {
                useCaseInk = new UseCasesShared.DTOs.Ink()
                {
                    Id = ink.Id,
                    Manufacturer = ink.Manufacturer,
                    Colour = ink.Colour
                };
            }

            return useCaseInk;
        }
    }
}
