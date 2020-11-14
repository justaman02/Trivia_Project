#include "StaticsManger.h"

StatisticsManager::StatisticsManager()
{
	this->m_dataBase = new SqliteDataBase();
}

stats StatisticsManager::getStatistics(string name)
{
	stats playerStats;
	playerStats.answerCount = m_dataBase->getNumOfTotalAnswers(name);
	playerStats.avargeTime = m_dataBase->getPlayerAverageAnswerTime(name);
	playerStats.correctCount = m_dataBase->getNumOfCorrectAnswers(name);
	playerStats.gamesPlayed = m_dataBase->getNumOfPlayerGames(name);

	return playerStats;
}

map<string, int> StatisticsManager::topScores()
{
	return m_dataBase->getScoreTable();
}

unsigned int StatisticsManager::getId()
{
	return (unsigned int)this->m_dataBase->LastId();
}
