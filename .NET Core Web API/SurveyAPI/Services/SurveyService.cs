﻿using SurveyAPI.Interfaces;
using SurveyAPI.Models;
using System;
using System.Collections.Generic;
using SurveyAPI.Dtos;

namespace SurveyAPI.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly ISurveyRepository _repository;
        public SurveyService(ISurveyRepository repository)
        {
            _repository = repository;
        }

        public SurveyResultDto GetSurveyResults(int surveyId)
        {
            return _repository.GetSurveyResult(surveyId);

        }

        public void DeleteSurvey(int surveyId)
        {
            _repository.DeleteSurvey(surveyId);
        }

        public Survey GetSurveyQuestions(int surveyId)
        {
            return _repository.GetSurvey(surveyId);
        }

        public Survey AddSurvey(Survey survey)
        {
            return _repository.AddSurvey(survey);
        }

        public SurveyDto AddSurveyAnswer(SurveyDto answer)
        {
            return _repository.AddSurveyResult(answer);
        }

        public OfferedAnswerResult GetOfferedAnswersForSurvey(int surveyId)
        {
            return _repository.GetOfferedAnswersForSurvey(surveyId);
        }

        public Participant AddSurveyParticipant(Participant participant)
        {
            return _repository.AddSurveyParticipant(participant);
        }

        public Question AddSurveyQuestion(Question question)
        {
            return _repository.AddSurveyQuestion(question);
        }

        public OfferedAnswer AddOfferedAnswer(OfferedAnswerDto offeredAnswer)
        {
            return _repository.AddOfferedAnswer(offeredAnswer);
        }

        public List<Survey> GetAllSurveys()
        {
            return _repository.GetAllSurveys();
        }

        public List<Question> GetAllQuestions()
        {
            return _repository.GetAllQuestions();
        }
    }
}