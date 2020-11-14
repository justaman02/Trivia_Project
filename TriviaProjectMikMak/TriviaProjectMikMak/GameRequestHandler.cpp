#include "GameRequestHandler.h"

bool GameRequestHandler::isRequestRelevant(RequestInfo req)
{
	return false;
}
GameRequestHandler::GameRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room, Game* game)
{
	this->m_factory = handler;
	this->m_game = game;
	this->m_room = room;
	this->m_user = user;
}
RequestResult GameRequestHandler::handleRequest(RequestInfo req)
{
	RequestResult res{};
	if (req.id == getquestion)
	{
		res = this->getQuestion(req);
		return res;
	}
	if (req.id == submitanswer)
	{
		res = this->submitAnswer(req);
		return res;
	}
}

RequestResult GameRequestHandler::getQuestion(RequestInfo req)
{
	int resCode = 0;
	RequestResult res{};
	GetQuestionResponse response;
	Question q = this->m_game->getQuestionForUser(*this->m_user);
	response.answers = q.getPossibleAnswers();
	response.question = q.getQuestion();
	response.status = success;
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	res.next = this;
	return res;
}

RequestResult GameRequestHandler::submitAnswer(RequestInfo req)
{
	int resCode = 0;
	RequestResult res{};
	SubmitAnswerRequest request;
	SubmitAnswerResponse response;
	request = JsonRequestPacketDeserializer::deserializerSubmitAnswerRequest(req.buffer);
	this->m_game->submitAnswer(*this->m_user, request.answerId);
	response.correctAnswerId = 3;
	response.status = success;
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	res.next = this;
	return res;
}

//RequestResult GameRequestHandler::getQuestion(RequestInfo info)
//{
//	return Re
//}
