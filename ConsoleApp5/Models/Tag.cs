using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    public class Tag
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
