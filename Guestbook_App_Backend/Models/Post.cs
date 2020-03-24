using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Guestbook_App_Backend.Models
{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string OAuthUserId { get; set; }

        public string[] Likes { get; set; }

        public string Title { get; set; }

        public string BodyText { get; set; }

        public string CreationDate { get; set; }

    }
}
