using System.Collections.Generic;
using Adapters.DTOs;
using UseCases;
using UseCasesShared.Interfaces.Storage;

namespace Adapters
{
    public class PenCollectorAdapter : IPenCollectorAdapter
    {
        public IPenCollectorInteractor PenCollectorInteractor { get; set; }

        public PenCollectorAdapter(IStorage storage)
        {
            PenCollectorInteractor = new PenCollectorInteractor(storage);
        }

        public bool InkPen(Pen pen, Ink ink)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollectorInteractor.InkPen(useCasePen, useCaseInk);
        }

        public bool AcquiresInk(Ink ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollectorInteractor.AcquiresInk(useCaseInk);
        }

        public bool AcquiresPen(Pen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollectorInteractor.AcquiresPen(useCasePen);
        }

        public List<Ink> ListsInks()
        {
            var useCaseInks = PenCollectorInteractor.ListsInks();
            var inks = new List<Ink>();
            foreach(var useCaseInk in useCaseInks)
            {
                inks.Add(UseCaseDtoToDtoConverter.Convert(useCaseInk));
            }
            return inks;
        }

        public List<Pen> ListsPens()
        {
            var useCasePens = PenCollectorInteractor.ListsPens();
            var pens = new List<Pen>();
            foreach (var useCaseInk in useCasePens)
            {
                pens.Add(UseCaseDtoToDtoConverter.Convert(useCaseInk));
            }
            return pens;
        }

        public bool UpdatesInkDetails(Ink ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollectorInteractor.UpdatesInkDetails(useCaseInk);
        }

        public bool UpdatesPenDetails(Pen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollectorInteractor.UpdatesPenDetails(useCasePen);
        }

        public bool GetsRidOfInk(Ink ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollectorInteractor.GetsRidOfInk(useCaseInk);
        }

        public bool GetsRidOfPen(Pen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollectorInteractor.GetsRidOfPen(useCasePen);
        }
    }
}
