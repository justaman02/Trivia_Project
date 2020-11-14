#pragma once
#include "IDataBase.h"
#include <map>
#include "Game.h"
#include <vector>
#include "Room.h"
using std::map;
using std::vector;
class GameManager
{
private:
	IDataBase* m_dataBase;
	vector<Game*> m_games;
public:
	Game* getLastGame();
	GameManager(IDataBase* db);
	Game* createGame(Room room);
	void deleteGame(Game*);
};

