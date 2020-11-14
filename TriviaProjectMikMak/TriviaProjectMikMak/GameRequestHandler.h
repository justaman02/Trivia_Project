#pragma once
#include "Handlers.h"
#include "IRequestHandler.h"
#include "Game.h"
class RequestHandlerFactory;
class GameRequestHandler : public IRequestHandler
{
public:
	GameRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room, Game* game);
	bool isRequestRelevant(RequestInfo req);
	RequestResult handleRequest(RequestInfo req);
private:
	LoggedUser* m_user;
	Room* m_room;
	Game* m_game;
	RequestHandlerFactory* m_factory;
	RequestResult getQuestion(RequestInfo);
	RequestResult submitAnswer(RequestInfo);
	RequestResult getGameResults(RequestInfo);
	RequestResult leaveGame(RequestInfo);
};

