using System;
using System.Collections.Generic;
using System.Text;

namespace directry.Models
{
    public class Mappable
    {
        public int Id { get; set; }

        public String Visibility { get; set; }

        public String IconImageName { get; set; }
        public String MappableType { get; set; }

        public Location Location { get; set; }
    }
}
