#pragma once
#include <iostream>
#include <io.h>
#include <sstream>
#include <list>
#include "Question.h"
#include <map>
using std::list;
using std::string;
using std::map;
class IDataBase
{
public:
	virtual bool doesUserExists(string name) = 0;
	virtual bool doesPasswordMatch(string password) = 0;
	virtual void addNewUser(string name, string password, string email) = 0;
	virtual vector<Question> getQuestions() = 0;
	virtual float getPlayerAverageAnswerTime(string name) = 0;
	virtual int getNumOfCorrectAnswers(string name) = 0;
	virtual int getNumOfTotalAnswers(string name) = 0;
	virtual int getNumOfPlayerGames(string name) = 0;
	virtual int getSocre(string name,int roomId) = 0;
	virtual map<string, int> getScoreTable() = 0;
	virtual int LastId()= 0;
};

