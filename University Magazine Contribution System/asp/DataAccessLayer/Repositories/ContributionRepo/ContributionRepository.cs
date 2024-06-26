﻿using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.ContributionRepo
{
    public class ContributionRepository : IContributionRepository
    {
        private readonly UniMagDbContext _context;

        public ContributionRepository(UniMagDbContext context)
        {
            _context = context;
        }
        public async Task<Contribution> AddContributionAsync(Contribution contribution)
        {
            var createdContribution = await _context.contributions.AddAsync(contribution);
            await _context.SaveChangesAsync();
            return createdContribution.Entity;
        }
        public async Task<Contribution> GetByIdAsync(int id)
        {
            return await _context.contributions.FirstOrDefaultAsync(u => u.ContributionID == id);
        }
        public async Task<IEnumerable<Contribution>> GetAllAsync()
        {
            return await _context.contributions.ToListAsync();
        }
        public async Task UpdateAsync(Contribution contribution)
        {
            _context.contributions.Update(contribution);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var contributionID = await GetByIdAsync(id);
            if(contributionID != null)
            {
                _context.contributions.Remove(contributionID);
                await _context.SaveChangesAsync();
            }
        }
    }
}
