﻿using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IProdutoService : IDisposable 
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
