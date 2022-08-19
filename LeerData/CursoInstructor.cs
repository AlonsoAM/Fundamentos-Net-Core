using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerData
{
    public class CursoInstructor
    {
        public int CursoID { get; set; }
        public Curso? Curso { get; set; }
        public int InstructorID { get; set; }
        public Instructor? Instructor { get; set; }
    }
}
