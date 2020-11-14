#include "RoomMemberRequestHandler.h"

RoomMemberRequestHandler::RoomMemberRequestHandler(RequestHandlerFactory* handler, LoggedUser* user, Room* room)
{
	m_handlerFactory = handler;
	this->m_room = room;
	this->m_user = user;
}

bool RoomMemberRequestHandler::isRequestRelevant(RequestInfo req)
{
	return false;
}

RequestResult RoomMemberRequestHandler::handleRequest(RequestInfo req)
{
	
	if (req.id == leaveRoomResponse)
	{
		int resCode = 0;
		RequestResult res{};
		StartGameResponse response;
		RoomManager* roomM = this->m_handlerFactory->getRoomManager();
		roomM->leaveRoom(this->m_room->getId(), *(this->m_user));
		response.status = success;

		res.responce = JsonResponsePacketSerializer::serializeResponse(response);
		res.next = this->m_handlerFactory->createMenuRequestHandler(this->m_handlerFactory,this->m_user);
		return res;
	}
	else if(req.id == getRoomStateResponse)
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
		RoomManager* roomM = this->m_handlerFactory->getRoomManager();
		m_room->removeUser(*this->m_user);
		int rescode = loginM->logout(this->m_user->getUserName());
		response.status = rescode;
		if (response.status == success)
		{
			res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory);
		}
		std::vector<unsigned char> resbuff = JsonResponsePacketSerializer::serializeResponse(response);
		res.responce = resbuff;
		res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory);
		return res;
	}
}
