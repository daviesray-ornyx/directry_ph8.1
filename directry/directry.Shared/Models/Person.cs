using System;
using System.Collections.Generic;
using System.Text;

namespace directry.Models
{
    public class Person
    {
        public int Id { get; set; }

        public String FullName { get; set; }

        public String ProfilePic { get; set; }          // NOTE: We need to change this to image types...

        public String ProfilePicImageType { get; set; }

        public String  ProfilePicImageName { get; set; }

        public int[] WorksAt { get; set; }

        public int[] Owns { get; set; }
    }
}
