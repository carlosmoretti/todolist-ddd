using System;

namespace Domain.Model
{
    public class Todo : EntityBase
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
