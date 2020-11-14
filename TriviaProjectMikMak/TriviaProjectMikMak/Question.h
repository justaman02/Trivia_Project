#pragma once
#include <stdio.h>
#include <string>
#include <vector>
#include <map>
using std::string;
using std::vector;
using std::map;
class Question {
	std::string m_question;
	std::vector<std::string> m_possibleAnswers;
public:
	Question(string question, vector<string> answers);
	Question();

	std::string getQuestion();
	map<string,string> getPossibleAnswers();
	Question& operator=(const Question& other);
	std::string getCorrectAnswer();
	

};