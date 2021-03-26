using System;
using UseCasesShared.Interfaces.DTOs;

namespace StorageSqlite.Schema
{
    public class SchemaToUseCaseDtoConverter
    {
        public static IPen Convert(Pen pen, IInk ink)
        {
            UseCasesShared.DTOs.Pen useCasePen = new UseCasesShared.DTOs.Pen()
            {
                Id = pen.Id.ToString(),
                Manufacturer = pen.Manufacturer,
                Model = pen.Model,
                Ink = ink
            };

            return useCasePen;
        }

        public static IInk Convert(Ink ink)
        {
            UseCasesShared.DTOs.Ink useCaseInk = new UseCasesShared.DTOs.Ink()
            {
                Id = ink.Id.ToString(),
                Manufacturer = ink.Manufacturer,
                Colour = ink.Colour
            };

            return useCaseInk;
        }
    }
}
