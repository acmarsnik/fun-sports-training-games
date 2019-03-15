using BusinessContracts;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FstgWebApi.Models
{
    public class Score : Score
    {
        //[BsonId]
        public int Id { get; set; }
        //[BsonElement]
        public int Value { get; set; }

    }
}
