﻿using UrnaEletronica.Model;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace UrnaEletronica.Data
{
    public class VoteRepository : IVoteRepository
    {
        private readonly DbAcess _context;

        public VoteRepository(DbAcess context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Candidate>> GetVotesByCandidates()
        {
            return await _context.Candidate.AsNoTracking().Include(x => x.Votes).ToListAsync();
        }

        public async Task InsertVote(Vote vote)
        {
            await _context.Vote.AddAsync(vote);
            await _context.SaveChangesAsync();
        }
    }
}
