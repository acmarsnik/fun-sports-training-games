using System;
using FstgWebApi.DataContracts;

namespace FstgWebApi.DataModels
{
    public class Score: IScore
    {
        public int _id { get; set; }
        public int UserId { get; set; }
        public int Value { get; set; }
    }
}
