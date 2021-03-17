using Interactors.DTOs;

namespace Interactors
{
    public interface IPenCollectorInteractor
    {
        void InkPen(IPen pen, IInk ink);
    }
}