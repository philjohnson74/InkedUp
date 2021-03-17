using System;
namespace Interactors.DTOs
{
    public static class DtoToUseCaseDtoConverter
    {
        public static UseCases.DTOs.IPen Convert(IPen pen)
        { 
            UseCases.DTOs.Pen useCasePen = new UseCases.DTOs.Pen()
            {
                Id = pen.Id,
                Manufacturer = pen.Manufacturer,
                Ink = Convert(pen.Ink)
            };

            return useCasePen;
        }

        public static UseCases.DTOs.IInk Convert(IInk ink)
        {
            UseCases.DTOs.Ink useCaseInk = new UseCases.DTOs.Ink()
            {
                Id = ink.Id,
                Manufacturer = ink.Manufacturer,
                Colour = ink.Colour
            };

            return useCaseInk;
        }
    }
}
