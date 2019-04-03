using System;

namespace FstgWebApi.DataContracts
{
    public interface IScore
    {
        Guid _id { get; set; }
        int UserId { get; set; }
        int Value { get; set; }
    }
}
