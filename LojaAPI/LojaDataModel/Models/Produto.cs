using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDataModel.Models
{
    public class Produto
    {

        [BsonElement("_id")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QntDisponivel { get; set; }
        public double Preco { get; set; }
        public DateTime DataInsercao{ get; set; }


        public Produto()
        {
            DataInsercao = DateTime.Now;
        }
    }
}
