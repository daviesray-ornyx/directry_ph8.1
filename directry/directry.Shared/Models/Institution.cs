using System;
using System.Collections.Generic;
using System.Text;

namespace directry.Models
{
    public class Institution
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Logo { get; set; }

        public String LogoImageType { get; set; }

        public String LogoImageName { get; set; }

        public int[] Workers { get; set; }

        public int[] Ownser { get; set; }       // Note the spelling mistake on owners
    }
}
