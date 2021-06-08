using System.Collections.Generic;
using UseCasesShared.DTOs;

namespace UseCases
{
    public interface IPenCollectorInteractor
    {
        bool InkPen(Pen pen, Ink ink);
        bool AcquiresInk(Ink ink);
        bool AcquiresPen(Pen pen);
        List<Ink> ListsInks();
        List<Pen> ListsPens();
        bool UpdatesInkDetails(Ink ink);
        bool UpdatesPenDetails(Pen pen);
        bool GetsRidOfInk(Ink ink);
        bool GetsRidOfPen(Pen pen);
    }
}