using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace LojaDataModel.Models
{
   public class Cliente
    {
        [BsonElement("_id")]
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCriacao { get; set; }


        public Cliente()
        {
            DataCriacao = DateTime.Now;
        }
    }

}
