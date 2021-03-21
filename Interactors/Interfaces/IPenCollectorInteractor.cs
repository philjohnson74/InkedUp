using System.Collections.Generic;
using Interactors.DTOs;

namespace Interactors
{
    public interface IPenCollectorInteractor
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