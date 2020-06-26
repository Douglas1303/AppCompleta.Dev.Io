using Dev.AppHard.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.AppHard.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; }
        public string Imagem { get; set; }

        [Moeda]
        [Required(ErrorMessage = "o campo {0} é obrigatório")]
        public decimal Valor { get; set; }


        [ScaffoldColumn(false)] //Não considerar essa coluna quando fazer o Scaffold
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

       
        public FornecedorViewModel Fornecedor { get; set; }

        //Lista de Fornecedores
        public IEnumerable <FornecedorViewModel> Fornecedores { get; set; }
    }
}
