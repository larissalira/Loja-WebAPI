
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using LojaServices;
using LojaDataModel.Models;

namespace LojaAPI.Controllers
{
    public class ProdutoController : ApiController
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }
        
        public HttpResponseMessage Get(int id)
        {
            var produto = _produtoService.Get(id);
            if (produto != null)
                return Request.CreateResponse(HttpStatusCode.OK, produto);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Produto not found for provided id.");
        }

        public HttpResponseMessage GetAll()
        {
            var produto = _produtoService.GetAll();
            if (produto.Any())
                return Request.CreateResponse(HttpStatusCode.OK, produto);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No produtos found.");
        }

        public void Post([FromBody]Produto produto)
        {
            _produtoService.Insert(produto);
        }
        public void Delete(int id)
        {
            _produtoService.Delete(id);
        }
        public void Put([FromBody]Produto produto)
        {
            _produtoService.Update(produto);
        }
    }
}