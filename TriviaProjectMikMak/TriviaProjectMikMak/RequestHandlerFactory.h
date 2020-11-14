#pragma once
#include "Handlers.h"
#include "LoginManger.h"
#include "IDataBase.h"
#include "GameManager.h"

#include "MenuRequestHandler.h"
#include "RoomAdminRequestHandler.h"
#include "RoomMemberRequestHandler.h"
#include "GameRequestHandler.h"

class LoginRequestHandler;
class MenuRequestHandler;
class RoomAdminRequestHandler;
class RoomMemberRequestHandler;
class GameRequestHandler;
class RequestHandlerFactory
{
public:
	LoginRequestHandler* createLoginRequestHandler(RequestHandlerFactory* handler);
	MenuRequestHandler* createMenuRequestHandler(RequestHandlerFactory* handler,LoggedUser* user);
	RoomAdminRequestHandler* createRoomAdminRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room);
	RoomMemberRequestHandler* createRoomMemberRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room);
	GameRequestHandler* createGameRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room, Game* game);
	LoginManager* getLoginManager();
	RoomManager* getRoomManager();
	StatisticsManager* getStatsManager();
	GameManager* getGameManager();

private:
	LoginManager* m_loginManager;
	RoomManager* m_RoomManager;
	StatisticsManager* m_statsManager;
	IDataBase* m_database;
	GameManager* m_gameManager;

};

