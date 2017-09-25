using LojaDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaServices
{
   public interface IClienteService
    {
        void Insert(Cliente cliente);
        Cliente Get(int i);
        IQueryable<Cliente> GetAll();
        void Delete(int id);
        void Update(Cliente cliente);
    }
}
