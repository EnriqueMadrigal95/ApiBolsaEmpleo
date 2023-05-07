using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class MyDbContext : DbContext //, IMyDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Candidato> Candidato { get; set; } = default!;

        //public Task<int> SaveChangesAsync()
        //{
        //    throw new NotImplementedException();
        //}

        public DbSet<FormacionAcademica> Formaciones { get; set; }

        public DbSet<Experiencia> Experiencias { get; set; }

        public DbSet<Habilidad> Habilidades { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<OfertaLaboral> OfertasLaborales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many
            
            modelBuilder.Entity<FormacionAcademica>()
            .HasOne<Candidato>(formaciones => formaciones.Candidato)
            .WithMany(candidato => candidato.Formaciones)
            .HasForeignKey(k => k.CandidatoId);

            //Candidato -> Experiencia

            modelBuilder.Entity<Experiencia>()
             .HasOne<Candidato>(experiencias => experiencias.Candidato)
             .WithMany(candidato => candidato.Experiencias)
             .HasForeignKey(k => k.CandidatoId);


            // Many to Many

     

            modelBuilder.Entity<Candidato>()
                .HasMany(candidato => candidato.Habilidades)
                .WithMany(habilidades => habilidades.Candidatos)
                .UsingEntity(j => j.ToTable("CandidatoHabilidad"));


            // One to Many
      
            modelBuilder.Entity<OfertaLaboral>()
            .HasOne<Empresa>(ofertas => ofertas.Empresa)
            .WithMany(empresa => empresa.Ofertas)
            .HasForeignKey(k => k.EmpresaId);

        }
    }
}
