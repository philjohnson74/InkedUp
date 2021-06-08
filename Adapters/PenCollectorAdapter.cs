using System.Collections.Generic;
using Adapters.DTOs;
using UseCases;
using UseCasesShared.Interfaces.Storage;

namespace Adapters
{
    public class PenCollectorAdapter : IPenCollectorAdapter
    {
        public IPenCollector PenCollector { get; set; }

        public PenCollectorAdapter(IStorage storage)
        {
            PenCollector = new PenCollector(storage);
        }

        public bool InkPen(Pen pen, Ink ink)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.InkPen(useCasePen, useCaseInk);
        }

        public bool AcquiresInk(Ink ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.AcquiresInk(useCaseInk);
        }

        public bool AcquiresPen(Pen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollector.AcquiresPen(useCasePen);
        }

        public List<Ink> ListsInks()
        {
            var useCaseInks = PenCollector.ListsInks();
            var inks = new List<Ink>();
            foreach(var useCaseInk in useCaseInks)
            {
                inks.Add(UseCaseDtoToDtoConverter.Convert(useCaseInk));
            }
            return inks;
        }

        public List<Pen> ListsPens()
        {
            var useCasePens = PenCollector.ListsPens();
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
            return PenCollector.UpdatesInkDetails(useCaseInk);
        }

        public bool UpdatesPenDetails(Pen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollector.UpdatesPenDetails(useCasePen);
        }

        public bool GetsRidOfInk(Ink ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.GetsRidOfInk(useCaseInk);
        }

        public bool GetsRidOfPen(Pen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollector.GetsRidOfPen(useCasePen);
        }
    }
}
