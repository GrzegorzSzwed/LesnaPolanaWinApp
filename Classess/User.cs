using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace LesnaPolanaWinApp.Classess
{
    public class User
    {
        [BsonId]
        public ObjectId id;
        public string Name, Surname, Permission, Phone, Mail, Password;
        public DateTime LastDate { get; set; }

        public User()
        {

        }
        public User(string name, string surname, string permission, string mail)
        {
            this.Name = name;
            this.Surname = surname;
            this.Permission = permission;
            this.Mail = mail;
        }

        public User(string name, string surname, string permission, string mail, string phone) : this(name, surname, permission, mail)
        {
            this.Phone = phone;
        }

        public void CreatePassword(string password)
        {
            this.Password = password;
        }
    }
}
