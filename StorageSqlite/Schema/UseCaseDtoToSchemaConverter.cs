using System;

namespace StorageSqlite.Schema
{
    public class UseCaseDtoToSchemaConverter
    {
        public static Pen Convert(UseCasesShared.DTOs.Pen useCasePen)
        {
            int penId;
            int.TryParse(useCasePen.Id, out penId);

            Pen pen = new Pen()
            {
                Id = penId,
                Manufacturer = useCasePen.Manufacturer,
                Model = useCasePen.Model
            };

            if (useCasePen.Ink != null)
                pen.InkId = int.Parse(useCasePen.Ink.Id);

            return pen;
        }

        public static Ink Convert(UseCasesShared.DTOs.Ink useCaseInk)
        {
            int inkId;
            int.TryParse(useCaseInk.Id, out inkId);

            Ink ink = new Ink()
            {
                Id = inkId,
                Manufacturer = useCaseInk.Manufacturer,
                Colour = useCaseInk.Colour
            };

            return ink;
        }
    }
}
