﻿using System.Threading.Tasks;

namespace category.Application.Interfaces
{
    public interface IExampleRepository
    {
        Task<int> UpdateExampleNameById(int id, string name);
    }
}