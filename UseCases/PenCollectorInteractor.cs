using System.Collections.Generic;
using UseCases.DTOs;
using UseCasesShared.DTOs;
using UseCasesShared.Interfaces.Storage;

namespace UseCases
{
    public class PenCollectorInteractor : IPenCollectorInteractor
    {
        public IStorage Storage { get; set; }

        public PenCollectorInteractor(IStorage storage)
        {
            Storage = storage;
        }

        public bool InkPen(Pen pen, Ink ink)
        {
            Entities.Pen penEntity = DtoToEntityConverter.Convert(pen);
            Entities.Ink inkEntity = DtoToEntityConverter.Convert(ink);

            penEntity.InkUp(inkEntity);

            pen = EntityToDtoConverter.Convert(penEntity);

            return Storage.UpdatePen(pen);
        }

        public bool AcquiresInk(Ink ink)
        {
            return Storage.CreateInk(ink);
        }

        public bool AcquiresPen(Pen pen)
        {
            return Storage.CreatePen(pen);
        }

        public List<Ink> ListsInks()
        {
            return Storage.RetrieveInks();
        }

        public List<Pen> ListsPens()
        {
            return Storage.RetrievePens();
        }

        public bool UpdatesInkDetails(Ink ink)
        {
            return Storage.UpdateInk(ink);
        }

        public bool UpdatesPenDetails(Pen pen)
        {
            return Storage.UpdatePen(pen);
        }

        public bool GetsRidOfInk(Ink ink)
        {
            return Storage.DeleteInk(ink);
        }

        public bool GetsRidOfPen(Pen pen)
        {
            return Storage.DeletePen(pen);
        }
    }
}
