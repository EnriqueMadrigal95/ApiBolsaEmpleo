using DataAccess.Entities;
using DataAccess;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public  class EmpresaService : IEmpresaService
    {
        private readonly MyDbContext _myDbContext;

        public EmpresaService(MyDbContext myDbContext)
        {
             _myDbContext = myDbContext;
        }

        public async Task<Empresa> Create(Empresa empresa)
        {
            _myDbContext.Empresas.Add(empresa);
            await _myDbContext.SaveChangesAsync();

            return empresa;
        }

        public Task<Experiencia> Create(Experiencia experiencia)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            var empresa = await _myDbContext.Empresas.FirstOrDefaultAsync(u => u.Id == id);
            if (empresa != null)
            {
                _myDbContext.Empresas.Remove(empresa);
                await _myDbContext.SaveChangesAsync();
            }
        }


        public Task<List<Empresa>> GetAll()
        {
            return _myDbContext.Empresas.ToListAsync();
        }


        public async Task<Empresa> GetById(int id)
        {
            return await _myDbContext.Empresas.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Empresa empresa)
        {
            _myDbContext.Empresas.Update(empresa);
            await _myDbContext.SaveChangesAsync();
        }

        public Task Update(Experiencia experiencia)
        {
            throw new NotImplementedException();
        }

        Task<List<Experiencia>> IEmpresaService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Experiencia> IEmpresaService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
