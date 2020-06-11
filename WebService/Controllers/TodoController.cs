using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Model;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITodoRepository _todoRepository;
        public TodoController(IMapper mapper, ITodoRepository todoRepository)
        {
            _mapper = mapper;
            _todoRepository = todoRepository;
        }

        [HttpGet]
        public IEnumerable<TodoViewModel> Get()
        {
            return _mapper.Map<IEnumerable<TodoViewModel>>(_todoRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] TodoViewModel model)
        {
            if (model.Validation.Errors.Any())
                return BadRequest(new
                {
                    Messages = model.Validation.Errors
                });

            var obj = _mapper.Map<TodoViewModel, Todo>(model);
            _todoRepository.Add(obj);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody]TodoViewModel model)
        {
            if (model.Validation.Errors.Any())
                return BadRequest(new
                {
                    Messages = model.Validation.Errors
                });

            var obj = _mapper.Map<TodoViewModel, Todo>(model);
            _todoRepository.Update(obj);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _todoRepository.Remove(id);
            return Ok();
        }
    }
}