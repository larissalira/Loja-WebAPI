using MongoDB.Driver;
using LojaDataModel.Models;
using LojaDataModel.Repositorio;
using System.Configuration;

namespace LojaDataModel.UnityOfWork
{
    public class UnitOfWork
    {
        private MongoDatabase _database;
        protected Repositorio<Cliente> _clientes;
        protected Repositorio<Historico> _historico;
        protected Repositorio<Produto> _produtos;

        public UnitOfWork()
        {
           
            var connectionString = ConfigurationManager.AppSettings["MongoDBConectionString"];
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var databaseName = ConfigurationManager.AppSettings["MongoDBDatabaseName"];
            _database = server.GetDatabase(databaseName);
        }


        public Repositorio<Cliente> Clientes
        {
            get
            {
                if (_clientes == null)
                    _clientes = new Repositorio<Cliente>(_database, "clientes");

                return _clientes;
            }
        }

        public Repositorio<Historico> Historicos
        {
            get
            {
                if (_historico == null)
                    _historico = new Repositorio<Historico>(_database, "historico");

                return _historico;
            }
        }

        public Repositorio<Produto> Produtos
        {
            get
            {
                if (_produtos == null)
                    _produtos = new Repositorio<Produto>(_database, "produtos");

                return _produtos;
            }
        }

    }
}
