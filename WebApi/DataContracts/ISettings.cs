using System;

namespace FstgWebApi.DataContracts
{
    public interface ISettings
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
