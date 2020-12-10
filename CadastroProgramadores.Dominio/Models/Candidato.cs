using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CadastroProgramadores.Dominio.Models
{
    public class Candidato
    {
        public int CandidatoId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(50, ErrorMessage = "Use Menos Caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]

        public string Email { get; set; }

        public string Idade { get; set; }

        public string Tecnologias { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]

        public string Urllinkedin { get; set; }     


    }
}
