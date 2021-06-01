using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDePalavras.Models
{
    public class Contato
    {
        [Required (ErrorMessage ="Campo NOME é obrigatório!")]
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(70)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo ASSUNTO é obrigatório!")]
        [MaxLength(70)]
        public string Assunto { get; set; }
        [Required(ErrorMessage = "Campo MENSAGEM é obrigatório!")]
        [MaxLength(1000)]
        public string Mensagem { get; set; }
    }
}
