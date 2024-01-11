using System;
using System.Collections.Generic;

namespace DotNetBasicCrudApi.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public int Class { get; set; }
        public string? FatherName { get; set; }
    }
}
