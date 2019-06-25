using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB;
using LesnaPolanaWinApp.Classess;

namespace LesnaPolanaWinApp.Classess
{
    public class Item
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Amount { get; set; }

        public string Category { get; set; }
        public DateTime LastModified { get; set; }

        public Dictionary<string, double> Shops;

        public string userName { get; set; }
        public Item(){}

        public Item(string name, string unit, double amountIn, Dictionary<string, double> shops, User user, string category)
        {
            this.Name = name;
            this.Unit = unit;
            this.Shops = shops;
            this.Amount = amountIn;
            this.LastModified = DateTime.UtcNow;
            this.userName = string.Format("{0}_{1}", user.Name, user.Surname);
            this.Category = category;
        }
    }
}
