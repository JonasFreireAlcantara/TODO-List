using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/todo")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IServiceEvent _serviceEvent;

        public ToDoController(IServiceEvent serviceEvent) =>
            _serviceEvent = serviceEvent;

        [HttpGet]
        public IActionResult RecoverAll()
        {
            var events = _serviceEvent.RecoverAll();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public IActionResult Recover([FromRoute] int id)
        {
            var _event = _serviceEvent.RecoverById(id);
            return Ok(_event);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _serviceEvent.Delete(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] NewEventModel newEventModel)
        {
            var updated = _serviceEvent.Update(id, newEventModel);
            return Ok(updated);
        }

    }
}
