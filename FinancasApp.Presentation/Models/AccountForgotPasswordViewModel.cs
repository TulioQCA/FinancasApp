﻿using System.ComponentModel.DataAnnotations;

namespace FinancasApp.Presentation.Models
{
    /// <summary>
    /// Modelo de dados da página de recuperação de senha /Account/ForgotPassword
    /// </summary>
    public class AccountForgotPasswordViewModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email do usuário.")]
        public string Email { get; set; }
    }
}
