using System;
using System.Collections.Generic;
using UseCasesShared.Interfaces.DTOs;

namespace UseCasesShared.Interfaces.Storage
{
    public interface IStorage
    {
        bool CreatePen(IPen pen);
        List<IPen> RetrievePens();
        bool UpdatePen(IPen pen);
        bool DeletePen(IPen pen);

        bool CreateInk(IInk ink);
        List<IInk> RetrieveInks();
        bool UpdateInk(IInk ink);
        bool DeleteInk(IInk ink);
    }
}
