using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog161.ViewModel
{
    public class RegisterViewModel:LoginViewModel
    {
        [Display(Name = "Primeiro Nome")]
        [Required(ErrorMessage = "Por Favor digite seu primeiro nome")]
        public string FirstName { get; set; }

        [Display(Name = "Ultimo Nome")]
        [Required(ErrorMessage = "Por Favor digite seu ultimo nome")]
        public string LastName { get; set; }

        [Display(Name = "Role Name")]
        [Required(ErrorMessage = "Please select a role")]
        public string RoleName { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Por Favor Digite seu Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Por Favor digite seu email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
