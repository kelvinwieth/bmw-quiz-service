using BMWQuiz.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BMWQuiz.Infra.Data.Interfaces
{
    public interface IQuestionRepository
    {
        public Task<List<Question>> GetAllAsync();
    }
}
