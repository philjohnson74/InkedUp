using System.Collections.Generic;
using UseCasesShared.DTOs;

namespace UseCasesShared.Interfaces.Storage
{
    public interface IStorage
    {
        bool CreatePen(Pen pen);
        List<Pen> RetrievePens();
        bool UpdatePen(Pen pen);
        bool DeletePen(Pen pen);

        bool CreateInk(Ink ink);
        List<Ink> RetrieveInks();
        bool UpdateInk(Ink ink);
        bool DeleteInk(Ink ink);
    }
}
