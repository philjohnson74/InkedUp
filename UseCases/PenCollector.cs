using System;
using Entities;

namespace UseCases
{
    public class PenCollector
    {
        public void InkPen(Pen pen, Ink ink)
        {
            pen.InkUp(ink);
        }
    }
}
