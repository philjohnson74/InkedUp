using System;
using UseCases.DTOs;
using UseCasesShared.Interfaces.DTOs;

namespace UseCases
{
    public class PenCollector : IPenCollector
    {
        public void InkPen(IPen pen, IInk ink)
        {
            Entities.Pen penEntity = DtoToEntityConverter.Convert(pen);
            Entities.Ink inkEntity = DtoToEntityConverter.Convert(ink);

            penEntity.InkUp(inkEntity);
        }
    }
}
