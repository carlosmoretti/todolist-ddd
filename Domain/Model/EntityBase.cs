using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
    }
}
