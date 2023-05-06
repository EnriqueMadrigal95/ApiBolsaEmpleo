﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class FormacionAcademica
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        
      
        public int CandidatoId { get; set; }
        public Candidato? Candidato { get; set;}
    }
}
