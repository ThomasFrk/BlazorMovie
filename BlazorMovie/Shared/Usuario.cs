using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovie.Shared
{
    public class Usuario
    {

        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6,ErrorMessage ="Senha deve ter 6 ou mais caracteres")]
        public string Senha { get; set; }

        [Required]
        [Compare("Senha", ErrorMessage ="Senhas não batem")]
        //nao consegui fazer o CompareProperty porque fala que o comando nao existe, mesmo baixando o pacote experimental
        public string ConfirmarSenha { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Aceitar os termos de serviço")]
        public bool TermosServ { get; set; }
    }
}
