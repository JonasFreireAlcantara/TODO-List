using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IServiceEvent
    {
        EventModel Create(NewEventModel newEventModel);
        EventModel Update(int id, NewEventModel newEventModel);
        void Delete(int id);
        EventModel RecoverById(int id);
        IEnumerable<EventModel> RecoverAll();
    }
}
