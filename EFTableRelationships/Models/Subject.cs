using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFTableRelationships.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Teacher Teacher { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }
    }
}
