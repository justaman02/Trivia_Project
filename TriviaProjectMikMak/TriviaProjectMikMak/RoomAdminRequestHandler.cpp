#include "RoomAdminRequestHandler.h"

RoomAdminRequestHandler::RoomAdminRequestHandler(RequestHandlerFactory* handler, LoggedUser* user,Room* room)
{
	m_handlerFactory = handler;
	this->m_room = room;
	this->m_user = user;
	
}

bool RoomAdminRequestHandler::isRequestRelevant(RequestInfo req)
{
	return false;
}

RequestResult RoomAdminRequestHandler::handleRequest(RequestInfo req)
{
	int resCode = 0;

	LoginManager* loginM = this->m_handlerFactory->getLoginManager();
	
	RequestResult res{};


	if (req.id == startGameResponse)
	{

		int resCode = 0;
		RequestResult res{};
		StartGameResponse response;
		RoomManager* roomM = this->m_handlerFactory->getRoomManager();
		response.status = success;

		res.responce = JsonResponsePacketSerializer::serializeResponse(response);
		res.next = this->m_handlerFactory->createGameRequestHandler(this->m_handlerFactory,this->m_user,this->m_room,this->m_handlerFactory->getGameManager()->createGame(*this->m_room));
		return res;
	}
	else if(req.id == closeRoomResponse)
	{
		int resCode = 0;
		RequestResult res{};
		CloseRoomResponse response;
		RoomManager* roomM = this->m_handlerFactory->getRoomManager();
		roomM->deleteRoom(m_room->getId());
		response.status = success;
		res.responce = JsonResponsePacketSerializer::serializeResponse(response);
		res.next = this;
		return res;
	}
	else if (req.id == getRoomStateResponse)
	{
		int resCode = 0;
		RequestResult res{};
		RoomManager* roomM = this->m_handlerFactory->getRoomManager();
		GetRoomStateResponse response = roomM->getRoomState(m_room->getId());
		response.status = success;
		res.responce = JsonResponsePacketSerializer::serializeResponse(response);
		res.next = this;
		return res;
	}
	else
	{
		LogoutResponse response;
		RequestResult res;
		LoginManager* loginM = this->m_handlerFactory->getLoginManager();
		int rescode = loginM->logout(this->m_user->getUserName());
		response.status = rescode;
		if (response.status == success)
		{
			res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory);
		}
		std::vector<unsigned char> resbuff = JsonResponsePacketSerializer::serializeResponse(response);
		res.responce = resbuff;
		return res;
	}



	return res;
}
