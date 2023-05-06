using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICandidatosService
    {
        public Task<List<Candidato>> GetAll();
        public Task<Candidato> Create(Candidato candidato);
        public Task<Candidato> GetById(int id);
        public Task Update(Candidato candidato);
        public Task Delete(int id);
    }
}
