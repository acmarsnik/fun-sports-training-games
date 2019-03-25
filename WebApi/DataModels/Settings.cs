using System;
using FstgWebApi.DataContracts;

namespace FstgWebApi.DataModels
{
    public class Settings: ISettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
