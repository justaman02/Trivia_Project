#include "Question.h"

Question::Question(string question, vector<string> answers)
{
	this->m_possibleAnswers = answers;
	this->m_question = question;
}

Question::Question()
{
}

std::string Question::getQuestion()
{
	return this->m_question;
}

map<string, string> Question::getPossibleAnswers()
{
	map<string, string> answers;
	int c = 0;
	for (auto& answer : this->m_possibleAnswers)
	{
		answers.emplace(std::to_string(c), answer);
		c++;
	}
	return answers;
}

Question& Question::operator=(const Question& other) 
{
	this->m_question = other.m_question;
	for (const auto& p : other.m_possibleAnswers)
	{
		this->m_possibleAnswers.push_back(p);
	}
	return *this;

}

std::string Question::getCorrectAnswer()
{
	return this->m_possibleAnswers[3];
}
