using System;
using System.Collections.Generic;
using Interactors.DTOs;
using UseCases;
using UseCasesShared.Interfaces.Storage;

namespace Interactors
{
    public class PenCollectorInteractor : IPenCollectorInteractor
    {
        public IPenCollector PenCollector { get; set; }

        public PenCollectorInteractor(IStorage storage)
        {
            PenCollector = new PenCollector(storage);
        }

        public bool InkPen(IPen pen, IInk ink)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.InkPen(useCasePen, useCaseInk);
        }

        public bool AcquiresInk(IInk ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.AcquiresInk(useCaseInk);
        }

        public bool AcquiresPen(IPen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollector.AcquiresPen(useCasePen);
        }

        public List<IInk> ListsInks()
        {
            var useCaseInks = PenCollector.ListsInks();
            var inks = new List<IInk>();
            foreach(var useCaseInk in useCaseInks)
            {
                inks.Add(UseCaseDtoToDtoConverter.Convert(useCaseInk));
            }
            return inks;
        }

        public List<IPen> ListsPens()
        {
            var useCasePens = PenCollector.ListsPens();
            var pens = new List<IPen>();
            foreach (var useCaseInk in useCasePens)
            {
                pens.Add(UseCaseDtoToDtoConverter.Convert(useCaseInk));
            }
            return pens;
        }

        public bool UpdatesInkDetails(IInk ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.UpdatesInkDetails(useCaseInk);
        }

        public bool UpdatesPenDetails(IPen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollector.UpdatesPenDetails(useCasePen);
        }

        public bool GetsRidOfInk(IInk ink)
        {
            var useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);
            return PenCollector.GetsRidOfInk(useCaseInk);
        }

        public bool GetsRidOfPen(IPen pen)
        {
            var useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            return PenCollector.GetsRidOfPen(useCasePen);
        }
    }
}
