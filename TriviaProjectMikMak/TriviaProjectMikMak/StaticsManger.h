#pragma once
#include "IDataBase.h"
#include "SqliteDataBase.h"
struct stats {
	int answerCount;
	int correctCount;
	int gamesPlayed;
	int score;
	float avargeTime;
};
class StatisticsManager
{
	IDataBase* m_dataBase;
public:
	StatisticsManager();
	stats getStatistics(string name);
	map<string, int> topScores();
	unsigned int getId();
};