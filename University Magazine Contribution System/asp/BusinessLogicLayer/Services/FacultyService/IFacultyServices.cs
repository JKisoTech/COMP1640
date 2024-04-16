﻿using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.FacultyService
{
    public interface IFacultyServices
    {
        public Task<FacultyDTO> GetFacultyByIdAsync(string id);
        public Task<List<FacultyDTO>> GetAllFacultyAsync();
        public Task AddFacultyAsync(FacultyDTO facultyDTO);
        public Task UpdateFacultyAsync(FacultyDTO facultyDTO);

        public Task<IEnumerable<Contribution>> GetContributionByFacultyID(string facultyID);
        public Task DeleteAsync(string id);
    }
}
