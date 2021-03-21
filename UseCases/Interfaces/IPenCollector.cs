using System.Collections.Generic;
using UseCasesShared.Interfaces.DTOs;

namespace UseCases
{
    public interface IPenCollector
    {
        bool InkPen(IPen pen, IInk ink);
        bool AcquiresInk(IInk ink);
        bool AcquiresPen(IPen pen);
        List<IInk> ListsInks();
        List<IPen> ListsPens();
        bool UpdatesInkDetails(IInk ink);
        bool UpdatesPenDetails(IPen pen);
        bool GetsRidOfInk(IInk ink);
        bool GetsRidOfPen(IPen pen);
    }
}