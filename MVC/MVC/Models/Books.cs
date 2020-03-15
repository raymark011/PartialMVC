using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{

    public class Books
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Publisher { get; set; }
        public String Author { get; set; }
        public String DatePublished { get; set; }
        public String BookFormat { get; set; }
    }
}
