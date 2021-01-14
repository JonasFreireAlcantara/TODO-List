using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class EventService : IServiceEvent
    {
        private readonly IRepositoryEvent _repositoryEvent;

        public EventService(IRepositoryEvent repositoryEvent)
        {
            _repositoryEvent = repositoryEvent;
        }


        public EventModel Create(NewEventModel newEventModel)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public IEnumerable<EventModel> RecoverAll()
        {
            // TODO
            throw new NotImplementedException();
        }

        public EventModel RecoverById(int id)
        {
            // TODO
            throw new NotImplementedException();
        }

        public EventModel Update(int id, NewEventModel newEventModel)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
