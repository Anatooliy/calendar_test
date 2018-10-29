using Calendar.DAL.Entities;
using System;

namespace Calendar.DAL.Interfaces
{
    public interface IClientManager : IDisposable
    {
        void Create(ClientProfile item);
    }
}
