using LojaDataModel.Models;
using LojaDataModel.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaServices
{
    public class HistoricoService : IHistoricoService
    {
        private readonly UnitOfWork _sUnitOfwork;
        public HistoricoService()
        {
            _sUnitOfwork = new UnitOfWork();
        }
        public Historico Get(int i)
        {
            return _sUnitOfwork.Historicos.Get(i);
        }
        public IQueryable<Historico> GetAll()
        {
            return _sUnitOfwork.Historicos.GetAll();
        }
        public void Delete(int id)
        {
            _sUnitOfwork.Clientes.Delete(c => c.Id, id);
        }
        public void Insert(Historico historico)
        {
            _sUnitOfwork.Historicos.Add(historico);
        }
        public void Update(Historico historico)
        {
            _sUnitOfwork.Historicos.Update(s => s.Id, historico.Id, historico);
        }
    }
}
