using System;
using System.Collections.Generic;
using System.Text;

namespace directry.Models
{
    public class PersonProfile
    {
        public int Id { get; set; }

        public String UserType { get; set; }

        public String Username { get; set; }

        public String  Status { get; set; }

        public Contact Contact { get; set; }

        public Mappable Mappable { get; set; }

        public Person Person { get; set; }

    }
}
