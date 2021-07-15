using System.Collections.Generic;
using SurveyAPI.Dtos;
using SurveyAPI.Models;

namespace SurveyAPI.Interfaces
{
    public interface ISurveyRepository
    {
        Survey GetSurvey(int surveyId);
        Survey AddSurvey(Survey survey);
        SurveyResultDto GetSurveyResult(int surveyId);
        SurveyDto AddSurveyResult(SurveyDto answer);
        OfferedAnswerResult GetOfferedAnswersForSurvey(int surveyId);
        void DeleteSurvey(int surveyId);
        Participant AddSurveyParticipant(Participant participant);
        Question AddSurveyQuestion(Question question);
        OfferedAnswer AddOfferedAnswer(OfferedAnswerDto offeredAnswer);
        List<Survey> GetAllSurveys();
        List<Question> GetAllQuestions();

    }
}