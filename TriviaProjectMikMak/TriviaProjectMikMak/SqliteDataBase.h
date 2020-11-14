#pragma once
#include "IDataBase.h"
#include "sqlite3.h"
#include "StaticsManger.h"
int CountCallBack(void* num, int count, char** data, char** columns);
int QuestionsCallBack(void* list, int count, char** data, char** columns);
int scoreCallBack(void* list, int count, char** data, char** columns);
int selectNumberCallBack(void* str, int count, char** data, char** columns);
int statsCallBack(void* str, int count, char** data, char** columns);

class SqliteDataBase:public IDataBase
{
public:
	//user queries
	SqliteDataBase();
	virtual bool doesUserExists(string name);
	virtual bool doesPasswordMatch(string password);
	virtual void addNewUser(string name, string password, string email);

	//for reconzize which user to check password for
	string getUserTGoCheck();
	void setUserToCheck(string name);


	//game queries
	virtual vector<Question> getQuestions();

	//statistics
	virtual float getPlayerAverageAnswerTime(string name);
	virtual int getNumOfCorrectAnswers(string name);
	virtual int getNumOfTotalAnswers(string name);
	virtual int getNumOfPlayerGames(string name);
	virtual int getSocre(string name,int roomId);
	virtual map<string, int> getScoreTable();

	virtual int LastId();


private:
	sqlite3* db;
	string userToCheck;
};

