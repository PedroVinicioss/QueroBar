using Microsoft.AspNetCore.Http;
using QueroBar.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBar.Models.ViewModels
{
    public class CreateEventViewModel
    {
        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        [StringLength(150)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Selecione a categoria")]
        public int CategoryId { get; set; } // Usando o ID da categoria

        [Required(ErrorMessage = "Insira a lotação do evento")]
        [Range(1, 1000, ErrorMessage = "A lotação deve estar entre 1 e 1000")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Selecione o gênero")]
        public int GenreId { get; set; } // Usando o ID do gênero

        [Required(ErrorMessage = "Insira a data e horário de início")]
        [Display(Name = "Horário de Início")]
        public DateTime? OpeningTime { get; set; }

        [Required(ErrorMessage = "Insira a data e horário de término")]
        [Display(Name = "Horário de Término")]
        public DateTime? ClosingTime { get; set; }

        [Required(ErrorMessage = "Insira o preço do ingresso")]
        [Range(0, double.MaxValue, ErrorMessage = "O preço do ingresso não pode ser negativo")]
        public float? Price { get; set; }

        [Required(ErrorMessage = "A descrição do evento é obrigatória")]
        [StringLength(300)]
        public string Description { get; set; }

        [Display(Name = "Imagem do Evento")]
        public IFormFile ImageFile { get; set; }

        public int Category { get; set; }
        public int Genre { get; set; }

        public string? Error { get; set; }
    }
}
