using LojaDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaServices
{
    public interface IProdutoService
    {
        void Insert(Produto produto);
        Produto Get(int i);
        IQueryable<Produto> GetAll();
        void Delete(int id);
        void Update(Produto produto);
    }
}
