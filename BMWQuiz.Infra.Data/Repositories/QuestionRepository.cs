﻿using BMWQuiz.Domain.Entities;
using BMWQuiz.Domain.Interfaces;
using BMWQuiz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMWQuiz.Infra.Data.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly BMWQuizDbContext _context;

        public async Task<List<Question>> GetAllAsync()
        {
            return await _context.Questions
                .AsNoTracking()
                .ToListAsync();
        }
    }
}