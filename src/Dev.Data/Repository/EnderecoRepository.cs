using AppMvcBasica.Models;
using Dev.Business.Interfaces;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
         public EnderecoRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                   .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId); 
        }


    }
}
