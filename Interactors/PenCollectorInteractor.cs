using System;
using Interactors.DTOs;
using UseCases;

namespace Interactors
{
    public class PenCollectorInteractor : IPenCollectorInteractor
    {
        public void InkPen(IPen pen, IInk ink)
        {
            UseCases.DTOs.IPen useCasePen = DtoToUseCaseDtoConverter.Convert(pen);
            UseCases.DTOs.IInk useCaseInk = DtoToUseCaseDtoConverter.Convert(ink);

            PenCollector penCollector = new PenCollector();
            penCollector.InkPen(useCasePen, useCaseInk);
        }
    }
}
