#pragma once
#include "Handlers.h"
#include "IRequestHandler.h"
class RequestHandlerFactory;
class RoomMemberRequestHandler : public IRequestHandler
{
public:
	RoomMemberRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room);
	bool isRequestRelevant(RequestInfo req);
	RequestResult handleRequest(RequestInfo req);
	LoggedUser* m_user;
	Room* m_room;
private:
	RequestHandlerFactory* m_handlerFactory;
};

