using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDataModel.Models;
using LojaDataModel.UnityOfWork;

namespace LojaServices
{
    
        public class ClienteService : IClienteService
        {
            private readonly UnitOfWork _sUnitOfwork;
            public ClienteService()
            {
                _sUnitOfwork = new UnitOfWork();
            }
            public Cliente Get(int i)
            {
                return _sUnitOfwork.Clientes.Get(i);
            }
            public IQueryable<Cliente> GetAll()
            {
                return _sUnitOfwork.Clientes.GetAll();
            }
            public void Delete(int id)
            {
                _sUnitOfwork.Clientes.Delete(c => c.Id, id);
            }
            public void Insert(Cliente cliente)
            {
                _sUnitOfwork.Clientes.Add(cliente);
            }
            public void Update(Cliente cliente)
            {
                _sUnitOfwork.Clientes.Update(s => s.Id, cliente.Id, cliente);
            }
        }

 }

