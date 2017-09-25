using System.Linq;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using LojaServices;
using LojaDataModel.Models;

namespace LojaAPI.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;
        public ClienteController()
        {
            _clienteService = new ClienteService();
        }
        
        // GET api/student/id
        public HttpResponseMessage Get(int id)
        {
            var cliente = _clienteService.Get(id);
            if (cliente != null)
                return Request.CreateResponse(HttpStatusCode.OK, cliente);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Cliente not found for provided id.");
        }

        public HttpResponseMessage GetAll()
        {
            var clientes = _clienteService.GetAll();
            if (clientes.Any())
                return Request.CreateResponse(HttpStatusCode.OK, clientes);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No clients found.");
        }

        public void Post([FromBody]Cliente cliente)
        {
            _clienteService.Insert(cliente);
        }
        public void Delete(int id)
        {
            _clienteService.Delete(id);
        }
        public void Put([FromBody]Cliente cliente)
        {
            _clienteService.Update(cliente);
        }
    }
}