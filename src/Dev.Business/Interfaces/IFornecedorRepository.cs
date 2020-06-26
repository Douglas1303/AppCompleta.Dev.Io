using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id); // Objeto para obter fornecedor e o seu endereco
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id); //Objeto para obter fornecedor, a lista de produtos e o endereco
    }
}
