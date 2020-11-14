#include "GameManager.h"

Game* GameManager::getLastGame()
{
	return this->m_games.at(this->m_games.size() - 1);
}

GameManager::GameManager(IDataBase* db)
{
	this->m_dataBase = db;
}

Game* GameManager::createGame(Room room)
{
	Game* g = new Game(room.getAllUsers(), this->m_dataBase->getQuestions());
	this->m_games.push_back(g);
	return g;
}

void GameManager::deleteGame(Game* game)
{
	this->m_games.erase(std::remove(this->m_games.begin(), this->m_games.end(), game), this->m_games.end());
	delete game;
}
