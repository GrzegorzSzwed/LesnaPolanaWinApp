using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using MongoDB.Bson;
namespace LesnaPolanaWinApp.Classess
{
    public class DBMigrator
    {
        private IMongoDatabase database;
        public DBMigrator(string database)
        {
            var client = new MongoClient();
            this.database = client.GetDatabase(database);
        }

        public T LoadRecordByName<T>(string table, string name)
        {
            var collection = database.GetCollection<T>(table);
            return collection.Find<T>(new BsonDocument("Name", name)).First();
        }

        public void UpdateRecord<T>(string table, ObjectId id, T record)
        {
            var collection = database.GetCollection<T>(table);

            var result = collection.ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new UpdateOptions { IsUpsert = true }
                );
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = database.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = database.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public void InsertListRecords<T>(string table, List<T> records)
        {
            var collection = database.GetCollection<T>(table);
            collection.InsertMany(records);
        }

        public void DeleteRecord<T>(string table, ObjectId id)
        {
            var collection = database.GetCollection<T>(table);
            collection.DeleteOne(new BsonDocument("_id", id));
        }

        public T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = database.GetCollection<T>(table);
            return collection.Find<T>(new BsonDocument("_id", id)).First();
        }

        public async Task<List<T>> LoadRecordsByAmount<T>(string table, float amount)
        {
            var collection = database.GetCollection<T>(table);
            var filtr = Builders<T>.Filter.Lt("Amount", amount);
            return await collection.Find(filtr).ToListAsync();
        }

        public T LoadRecordByLoginAndPassword<T>(string name, string surname, string password)
        {
            var collection = database.GetCollection<T>("users");
            var filtr = Builders<T>.Filter.Eq("Name", name) & Builders<T>.Filter.Eq("Surname", surname) & Builders<T>.Filter.Eq("Password", password);

            return collection.Find(filtr).FirstOrDefault();
        }
    }
}
