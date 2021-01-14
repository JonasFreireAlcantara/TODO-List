using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IRepositoryEvent
    {
        void Save(Event obj);
        void Remove(int id);
        Event GetById(int id);
        IList<Event> GetAll();
    }
}
