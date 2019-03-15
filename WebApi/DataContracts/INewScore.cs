using System;

namespace DataContracts
{
    interface IScore
    {
        int UserId { get; set; }
        int Score { get; set; }
    }
}
