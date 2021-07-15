using System.Collections.Generic;

namespace SurveyAPI.Dtos
{
    public class SurveyDto
    {
        public int SurveyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<SurveyAnswer> Answers { get; set; }
    }

    public class SurveyAnswer
    {
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int QuestionAnswersId { get; set; }

    }
}
