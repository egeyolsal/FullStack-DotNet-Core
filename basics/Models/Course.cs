using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; } // it can be null, so we use ? after string. If we don't use ?, it will give a warning that the property can be null.
        public string? Image { get; set; }  
        public string? description { get; set; }
        public string[]? Tags { get; set; }
        public bool isActive { get; set; }    
        public bool isHome { get; set; }    
    }
}