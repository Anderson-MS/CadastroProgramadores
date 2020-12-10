using CadastroProgramadores.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProgramadores.AcessoDados.Mapeamentos
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {

            builder.HasKey(c => c.CandidatoId);

            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Idade).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Tecnologias).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Urllinkedin).HasMaxLength(50).IsRequired();

            builder.ToTable("Candidato");

        }
    }
}


   

  

      

   

 