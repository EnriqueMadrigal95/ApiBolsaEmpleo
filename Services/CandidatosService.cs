using DataAccess.Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public  class CandidatosService : ICandidatosService
    {
        private readonly MyDbContext _myDbContext;

        public CandidatosService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public Task<List<Candidato>> GetAll()
        {
            return _myDbContext.Candidato.ToListAsync();
        }

        public async Task<Candidato> Create(Candidato candidato)
        {
            _myDbContext.Candidato.Add(candidato);
            await _myDbContext.SaveChangesAsync();

            return candidato;
        }
    }
}
