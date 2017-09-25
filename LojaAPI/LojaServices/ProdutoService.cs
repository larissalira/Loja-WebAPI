using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDataModel.Models;
using LojaDataModel.UnityOfWork;

namespace LojaServices
{
    public class ProdutoService :IProdutoService
    {
        private readonly UnitOfWork _sUnitOfwork;

        public ProdutoService()
        {
            _sUnitOfwork = new UnitOfWork();
        }
        public Produto Get(int i)
        {
            return _sUnitOfwork.Produtos.Get(i);
        }
        public IQueryable<Produto> GetAll()
        {
            return _sUnitOfwork.Produtos.GetAll();
        }
        public void Delete(int id)
        {
            _sUnitOfwork.Produtos.Delete(c => c.Id, id);
        }
        public void Insert(Produto produto)
        {
            _sUnitOfwork.Produtos.Add(produto);
        }
        public void Update(Produto produto)
        {
            _sUnitOfwork.Produtos.Update(s => s.Id, produto.Id, produto);
        }

      
    }
}
