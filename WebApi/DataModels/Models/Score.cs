using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FstgWebApi.Models
{
    public class Score
    {
        //[BsonId]
        public int id { get; set; }
        //[BsonElement]
        public int score { get; set; }

    }
}
