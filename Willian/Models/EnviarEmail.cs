using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Willian.Models
{
    public class EnviarEmail
    {
        [Required(ErrorMessage = "* Por favor Digite um Nome")]
        [MinLength(3, ErrorMessage = "* Mínimo 3 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "* Por favor Digite um Email")]
        [MinLength(5, ErrorMessage = "* Mínimo 3 caracteres")]
        [EmailAddress(ErrorMessage = "* Formato de Email inválido")]
        public string Email { get; set; }
        [MinLength(5, ErrorMessage = "* Mínimo 5 caracteres")]
        public string Mensagem { get; set; }
    }
}
