using UseCasesShared.Interfaces.DTOs;

namespace UseCases
{
    public interface IPenCollector
    {
        void InkPen(IPen pen, IInk ink);
    }
}