﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerData
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string? Alumno { get; set; }
        public int? Puntaje { get; set; }
        public string? ComentarioTexto { get; set; }
        public int CursoID { get; set; }
        public Curso? Curso { get; set; }
    }
}
