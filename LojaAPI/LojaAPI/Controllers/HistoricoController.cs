using LojaDataModel.Models;
using LojaServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LojaAPI.Controllers
{
    public class HistoricoController : ApiController
    {
        private readonly HistoricoService _historicoService;
        public HistoricoController()
        {
            _historicoService = new HistoricoService();
        }

        public HttpResponseMessage Get(int id)
        {
            var historico = _historicoService.Get(id);
            if (historico != null)
                return Request.CreateResponse(HttpStatusCode.OK, historico);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Historico not found for provided id.");
        }

        public HttpResponseMessage GetAll()
        {
            var historico = _historicoService.GetAll();
            if (historico.Any())
                return Request.CreateResponse(HttpStatusCode.OK, historico);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No historico found.");
        }

        public void Post([FromBody]Historico historico)
        {
            _historicoService.Insert(historico);
        }
        public void Delete(int id)
        {
            _historicoService.Delete(id);
        }
        public void Put([FromBody]Historico historico)
        {
            _historicoService.Update(historico);
        }
    }
}