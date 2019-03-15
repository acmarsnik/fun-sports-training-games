using System;

namespace FstgWebApi.DataContracts
{
    public interface IScore
    {
        int Id { get; set; }
        int UserId { get; set; }
        int Value { get; set; }
    }
}
