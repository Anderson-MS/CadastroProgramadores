using CadastroProgramadores.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProgramadores.AcessoDados.Mapeamentos
{
    public class CategoriaConhecimentoMap : IEntityTypeConfiguration<CategoriaConhecimento>
    {
        public void Configure(EntityTypeBuilder<CategoriaConhecimento> builder)
        {
            builder.HasKey(ce => ce.CategoriaConhecimentoId);

            builder.Property(ce => ce.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(ce => ce.Conhecimentos).WithOne(ce => ce.CategoriaConhecimento).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("CategoriaConhecimentos");




        }
    }
}
