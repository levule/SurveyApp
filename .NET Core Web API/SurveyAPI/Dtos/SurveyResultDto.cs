using System.Collections.Generic;
using SurveyAPI.Models;

namespace SurveyAPI.Dtos
{
    public class SurveyResultDto
    {
        public string Name { get; set; }

        public List<AnsweredQuestion> Questions { get; set; }
    }
}
