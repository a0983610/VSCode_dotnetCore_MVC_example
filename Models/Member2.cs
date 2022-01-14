using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1.Models
{
    public class Member2
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }

        public string Tel { set; get; }
        public string Gender { set; get; }

        public DateTime? Birthday { set; get; }
    }
}