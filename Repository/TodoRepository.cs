using Domain.Model;
using Persistence;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        private Contexto _contexto;
        public TodoRepository(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
