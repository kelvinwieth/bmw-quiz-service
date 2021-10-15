using BMWQuiz.Domain.Entities;
using BMWQuiz.Infra.Data.Context;
using BMWQuiz.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMWQuiz.Infra.Data.Repositories
{
    class QuestionOptionsRepository : IQuestionOptionRepository
    {
        private readonly BMWQuizDbContext _context;

        public QuestionOptionsRepository(BMWQuizDbContext context)
        {
            _context = context;
        }

        public async Task<List<QuestionOption>> GetAll()
        {
            return await _context.QuestionOptions
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
