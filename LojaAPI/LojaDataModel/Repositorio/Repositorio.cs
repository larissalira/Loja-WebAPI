using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LojaDataModel.Repositorio
{
    
        public class Repositorio<T> where T : class
        {
            private MongoDatabase _database;
            private string _tableName;
            private MongoCollection<T> _collection;


            // constructor inicializa banco e nome da tabela 
            public  Repositorio(MongoDatabase db, string tblName)
            {
                _database = db;
                _tableName = tblName;
                _collection = _database.GetCollection<T>(tblName);
            }

            
            public T Get(int i)
            {
                return _collection.FindOneById(i);
            }
        
            public IQueryable<T> GetAll()
            {
                MongoCursor<T> cursor = _collection.FindAll();
                return cursor.AsQueryable<T>();
            }
        
            public void Add(T entity)
            {
                _collection.Insert(entity);
            }
        
            public void Delete(Expression<Func<T, int>> queryExpression, int id)
            {
                var query = Query<T>.EQ(queryExpression, id);
                _collection.Remove(query);
            }

            
            public void Update(Expression<Func<T, int>> queryExpression, int id, T entity)
            {
                var query = Query<T>.EQ(queryExpression, id);
                _collection.Update(query, Update<T>.Replace(entity));
            }
        }
  }

