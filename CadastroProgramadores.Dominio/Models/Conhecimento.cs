using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CadastroProgramadores.Dominio.Models
{
    public class Conhecimento
    {
        public int ConhecimentoId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [StringLength(50, ErrorMessage ="Use Menos Caracteres")]
        public string Nome { get; set; }
        public int CategoriaConhecimentoID { get; set; }
        public CategoriaConhecimento CategoriaConhecimento { get; set; }

    }
}
