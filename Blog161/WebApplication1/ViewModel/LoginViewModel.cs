using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog161.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por Favor entre com seu nome.")]
        public string UserName { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Por favor entre com sua senha.")]
        public string Password { get; set; }

        [Display(Name = "Relembrar Login")]
        public bool RememberMe { get; set; }

    }
}
