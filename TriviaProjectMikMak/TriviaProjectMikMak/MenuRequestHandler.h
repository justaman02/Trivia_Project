#pragma once
#include "IRequestHandler.h"
#include "RoomManager.h"
#include "StaticsManger.h"
#include "RequestHandlerFactory.h"
#include "ServerEnum.h"
#include "LoggedUser.h"
class RequestHandlerFactory;
class MenuRequestHandler : public IRequestHandler
{
	static unsigned int roomIdCount;
	RequestHandlerFactory* m_handlerFactory;
	LoggedUser* user;
public:
	static unsigned int getRoomIdCount() ;
	MenuRequestHandler(RequestHandlerFactory* handler, LoggedUser* user);
	bool isRequestRelevant(RequestInfo req);
	RequestResult handleRequest(RequestInfo req);
	RequestResult signout(RequestInfo req);
	RequestResult getRooms(RequestInfo req);
	RequestResult getPlayersInRoom(RequestInfo req);
	RequestResult getStatistics(RequestInfo req);
	RequestResult joinRoom(RequestInfo req);
	RequestResult createRoom(RequestInfo req);
};

