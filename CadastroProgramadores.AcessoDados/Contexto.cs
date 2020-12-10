using CadastroProgramadores.AcessoDados.Mapeamentos;
using CadastroProgramadores.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProgramadores.AcessoDados
{
     public class Contexto : DbContext
     {
        public DbSet<Administrador> Admninistradores { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<CategoriaConhecimento> CategoriaConhecimentos { get; set; }
        public DbSet<Conhecimento> Conhecimentos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes )
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdmninistradoresMap());
            modelBuilder.ApplyConfiguration(new CandidatoMap());
            modelBuilder.ApplyConfiguration(new CategoriaConhecimentoMap());


        }

    }
}
