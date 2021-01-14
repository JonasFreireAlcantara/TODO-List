using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Infra.Data.Repository
{
    class EventRepository : IRepositoryEvent
    {
        private readonly List<Event> _events = new List<Event>();


        public IList<Event> GetAll()
        {
            return _events;
        }

        public Event GetById(int id)
        {
            return _events.Find(e => e.Id == id);
        }

        public void Remove(int id)
        {
            _events.RemoveAll(e => e.Id == id);
        }

        public void Save(Event obj)
        {
            _events.Add(obj);
        }
    }
}
