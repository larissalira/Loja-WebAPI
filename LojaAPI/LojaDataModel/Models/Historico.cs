using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDataModel.Models
{
    public class Historico
    {
        [BsonElement("_id")]
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataTransacao { get; set; }
        public List<Compra> Produtos  { get; set; }

        public Historico()
        {
            DataTransacao = DateTime.Now;
        }
    }
}
