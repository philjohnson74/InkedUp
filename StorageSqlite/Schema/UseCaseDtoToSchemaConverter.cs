using System;
using UseCasesShared.Interfaces.DTOs;

namespace StorageSqlite.Schema
{
    public class UseCaseDtoToSchemaConverter
    {
        public static Pen Convert(IPen useCasePen)
        {
            Pen pen = new Pen()
            {
                Id = useCasePen.Id,
                Manufacturer = useCasePen.Manufacturer,
                Model = useCasePen.Model,
                InkId = useCasePen.Ink.Id
            };

            return pen;
        }

        public static Ink Convert(IInk useCaseInk)
        {
            Ink ink = new Ink()
            {
                Id = useCaseInk.Id,
                Manufacturer = useCaseInk.Manufacturer,
                Colour = useCaseInk.Colour
            };

            return ink;
        }
    }
}
