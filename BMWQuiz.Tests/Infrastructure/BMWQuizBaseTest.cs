using BMWQuiz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace BMWQuiz.Tests.Infrastructure
{
    public class BMWQuizBaseTest : IDisposable
    {
        protected readonly BMWQuizDbContext _context;

        public BMWQuizBaseTest()
        {
            var options = new DbContextOptionsBuilder<BMWQuizDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new BMWQuizDbContext(options);

            _context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
