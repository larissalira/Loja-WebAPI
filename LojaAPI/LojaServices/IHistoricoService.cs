using LojaDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaServices
{
    interface IHistoricoService
    {
        void Insert(Historico historico);
        Historico Get(int i);
        IQueryable<Historico> GetAll();
        void Delete(int id);
        void Update(Historico historico);
    }
}
