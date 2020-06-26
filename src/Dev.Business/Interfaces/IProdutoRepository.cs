using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId); //Obter uma lista de produtos por fornecedor 
        Task<IEnumerable<Produto>> ObterProdutosFornecedores(); //Obter uma lista de produtos e fornecedores
        Task<Produto> ObterProdutoFornecedor(Guid id); //Obter um produto e o seu fornecedor 
    }
}
