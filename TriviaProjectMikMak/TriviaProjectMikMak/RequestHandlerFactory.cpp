#include "RequestHandlerFactory.h"



LoginRequestHandler* RequestHandlerFactory::createLoginRequestHandler(RequestHandlerFactory* handler)
{
	return new LoginRequestHandler(handler);
}

MenuRequestHandler* RequestHandlerFactory::createMenuRequestHandler(RequestHandlerFactory* handler,LoggedUser* user)
{
	return new MenuRequestHandler(handler,user);
}

RoomAdminRequestHandler* RequestHandlerFactory::createRoomAdminRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room)
{
	return new RoomAdminRequestHandler(handler, user,room);
}

RoomMemberRequestHandler* RequestHandlerFactory::createRoomMemberRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room)
{
	return new RoomMemberRequestHandler(handler, user, room);
}

GameRequestHandler* RequestHandlerFactory::createGameRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room, Game* game)
{
	return new GameRequestHandler(handler, user, room,game);
}



/* 
Return the login manager and if not exsits it's make one
*/
LoginManager* RequestHandlerFactory::getLoginManager()
{
	if (this->m_loginManager == nullptr)
	{
		this->m_loginManager = new LoginManager();
	}
	return this->m_loginManager;
}

RoomManager* RequestHandlerFactory::getRoomManager()
{
	if (this->m_RoomManager == nullptr)
	{
		this->m_RoomManager = new RoomManager();
	}
	return this->m_RoomManager;
}

StatisticsManager* RequestHandlerFactory::getStatsManager()
{
	if (this->m_statsManager == nullptr)
	{
		this->m_statsManager = new StatisticsManager();
	}
	return this->m_statsManager;
}

GameManager* RequestHandlerFactory::getGameManager()
{
	if (this->m_gameManager == nullptr)
	{
		this->m_gameManager = new GameManager(new SqliteDataBase());
	}
	return this->m_gameManager;
}
