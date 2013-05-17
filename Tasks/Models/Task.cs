using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
    }
}