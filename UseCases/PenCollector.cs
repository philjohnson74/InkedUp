using System;
using System.Collections.Generic;
using UseCases.DTOs;
using UseCasesShared.Interfaces.DTOs;
using UseCasesShared.Interfaces.Storage;

namespace UseCases
{
    public class PenCollector : IPenCollector
    {
        public IStorage Storage { get; set; }

        public PenCollector(IStorage storage)
        {
            Storage = storage;
        }

        public bool InkPen(IPen pen, IInk ink)
        {
            Entities.Pen penEntity = DtoToEntityConverter.Convert(pen);
            Entities.Ink inkEntity = DtoToEntityConverter.Convert(ink);

            penEntity.InkUp(inkEntity);

            pen = EntityToDtoConverter.Convert(penEntity);

            return Storage.UpdatePen(pen);
        }

        public bool AcquiresInk(IInk ink)
        {
            return Storage.CreateInk(ink);
        }

        public bool AcquiresPen(IPen pen)
        {
            return Storage.CreatePen(pen);
        }

        public List<IInk> ListsInks()
        {
            return Storage.RetrieveInks();
        }

        public List<IPen> ListsPens()
        {
            return Storage.RetrievePens();
        }

        public bool UpdatesInkDetails(IInk ink)
        {
            return Storage.UpdateInk(ink);
        }

        public bool UpdatesPenDetails(IPen pen)
        {
            return Storage.UpdatePen(pen);
        }

        public bool GetsRidOfInk(IInk ink)
        {
            return Storage.DeleteInk(ink);
        }

        public bool GetsRidOfPen(IPen pen)
        {
            return Storage.DeletePen(pen);
        }
    }
}
