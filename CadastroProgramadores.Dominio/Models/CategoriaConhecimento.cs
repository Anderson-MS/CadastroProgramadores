using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CadastroProgramadores.Dominio.Models
{
    public class CategoriaConhecimento
    {
        public int CategoriaConhecimentoId { get; set; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        [StringLength(50, ErrorMessage ="Use Menos caracteres" )]
        public string Nome { get; set; }

        public ICollection<Conhecimento> Conhecimentos { get; set; }
    }
}
