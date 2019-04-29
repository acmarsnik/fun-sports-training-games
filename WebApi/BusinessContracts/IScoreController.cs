using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FstgWebApi.DataContracts;
using FstgWebApi.DataModels;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FstgWebApi.BusinessContracts
{
    public interface IScoreController
    {
        Task<IActionResult> GetByIdAsync(string _id);
        Task<IActionResult> GetByUserIdAsync(int userId);
        Task<IActionResult> GetAsync();
        Task<IActionResult> CreateAsync(Score score);
        Task<IActionResult> UpdateAsync(string _id, Score score);
        Task<IActionResult> DeleteAsync(string _id);
        Task<IActionResult> DeleteAllAsync();
    }
}
