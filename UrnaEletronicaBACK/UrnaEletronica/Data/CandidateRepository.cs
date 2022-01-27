using UrnaEletronica.Model;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace UrnaEletronica.Data
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly DbAcess _context;

        public CandidateRepository(DbAcess context)
        {
            _context = context;
        }

        public async Task InsertCandidate(Candidate candidate)
        {
            await _context.Candidate.AddAsync(candidate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCandidate(Candidate candidate)
        {
            _context.Remove(candidate);
            await _context.SaveChangesAsync();  
        }
    }
}
