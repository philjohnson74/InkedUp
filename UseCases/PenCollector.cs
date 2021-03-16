using System;
using UseCases.DTOs;

namespace UseCases
{
    public class PenCollector
    {
        public void InkPen(Pen pen, Ink ink)
        {
            Entities.Pen penEntity = DtoToEntityConverter.Convert(pen);
            Entities.Ink inkEntity = DtoToEntityConverter.Convert(ink);

            penEntity.InkUp(inkEntity);
        }
    }
}
