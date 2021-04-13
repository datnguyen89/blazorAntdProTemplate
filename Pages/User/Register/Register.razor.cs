using System;
using System.ComponentModel.DataAnnotations;

namespace blazorAntdProTemplate.Pages.User
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
        public string? PostCode { set; get; }
        [Required]
        public string Phone { get; set; }

        [Required]
        public string Captcha { get; set; }
    }

    public partial class Register
    {
        private readonly RegisterModel _model = new RegisterModel();

        public void Reg()
        {
            Console.WriteLine(_model);
        }
    }
}