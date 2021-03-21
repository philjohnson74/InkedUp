using System;
namespace Interactors.DTOs
{
    public static class UseCaseDtoToDtoConverter
    {
        public static IPen Convert(UseCasesShared.Interfaces.DTOs.IPen useCasePen)
        { 
            Pen pen = new Pen()
            {
                Id = useCasePen.Id,
                Manufacturer = useCasePen.Manufacturer,
                Model = useCasePen.Model,
                Ink = Convert(useCasePen.Ink)
            };

            return pen;
        }

        public static IInk Convert(UseCasesShared.Interfaces.DTOs.IInk useCaseInk)
        {
            Ink ink = new Ink()
            {

                Manufacturer = useCaseInk.Manufacturer,
                Colour = useCaseInk.Colour
            };

            return ink;
        }
    }
}
