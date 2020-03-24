using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Guestbook_App_Backend.Models
{
   
    public class User
    {
        [BsonId]
        public string Id { get; set; }
        public string OAuthUserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string CreationDate { get; set; }

        public string[] Likes { get; set; }

    }
}


