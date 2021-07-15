using System.Collections.Generic;
using SurveyAPI.Dtos;
using SurveyAPI.Models;

namespace SurveyAPI.Interfaces
{
    public interface ISurveyService
    {
        SurveyResultDto GetSurveyResults(int surveyId);

        Survey AddSurvey(Survey survey);

        void DeleteSurvey(int surveyId);

        Survey GetSurveyQuestions(int surveyId);

        SurveyDto AddSurveyAnswer(SurveyDto surveyDto);

        OfferedAnswerResult GetOfferedAnswersForSurvey(int surveyId);

        Participant AddSurveyParticipant(Participant participant);

        Question AddSurveyQuestion(Question question);

        OfferedAnswer AddOfferedAnswer(OfferedAnswerDto offeredAnswer);

        List<Survey> GetAllSurveys();

        List<Question> GetAllQuestions();
    }
}