using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")] // Data Anotation
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage ="Valor fora da faixa: 1 - 10")] // Data Anotation
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
