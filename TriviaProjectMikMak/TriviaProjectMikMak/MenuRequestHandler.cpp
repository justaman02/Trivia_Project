#include "MenuRequestHandler.h"

unsigned int MenuRequestHandler::roomIdCount = 0;
unsigned int MenuRequestHandler::getRoomIdCount()
{
	return MenuRequestHandler::roomIdCount;
}

MenuRequestHandler::MenuRequestHandler(RequestHandlerFactory* handler, LoggedUser* user)
{
	this->m_handlerFactory = handler;
	this->user = user;
}
bool MenuRequestHandler::isRequestRelevant(RequestInfo req)
{
	return true;
}

RequestResult MenuRequestHandler::handleRequest(RequestInfo req)
{
	RequestResult res;
	switch (req.id)
	{
		case CreateRoom:
			res = this->createRoom(req);
			break;

		case GetRooms:
			res = this->getRooms(req);
			break;

		case GetPlayers:
			res = this->getPlayersInRoom(req);
			break;

		case JoinRoom:
			res = this->joinRoom(req);
			break;
		case getStats:
			res = this->getStatistics(req);
			break;
		case logout:
			res = this->signout(req);
			break;

				
	}
	return res;
}

RequestResult MenuRequestHandler::signout(RequestInfo req)
{
	LogoutResponse response;
	RequestResult res;
	LoginManager* loginM = this->m_handlerFactory->getLoginManager();
	int rescode = loginM->logout(this->user->getUserName());
	response.status = rescode;
	if (response.status == success)
	{
		res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory);
	}
	std::vector<unsigned char> resbuff = JsonResponsePacketSerializer::serializeResponse(response);
	res.responce = resbuff;
	return res;
}

RequestResult MenuRequestHandler::getRooms(RequestInfo req)
{
	GetRoomsResponse response;
	RequestResult res;
	RoomManager* roomM = this->m_handlerFactory->getRoomManager();
	std::vector<RoomData> rooms;
	std::vector<Room> temp = roomM->getRooms();

	std::vector<Room>::iterator it = temp.begin();
	for (it; it != temp.end(); it++)
	{
		rooms.push_back(it->getAllRoomData());
	}
	response.rooms = rooms;
	if (response.rooms.size() == 0)
	{
		response.status = noRooms;
	}
	else
	{
		response.status = success;
	}
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	res.next = this;
	return res;

}

RequestResult MenuRequestHandler::getPlayersInRoom(RequestInfo req)
{
	GetPlayersInRoomResponse response;
	RequestResult res;
	GetPlayersInRoomRequest request = JsonRequestPacketDeserializer::deserializeGetPlayersRequest(req.buffer);
	RoomManager* roomM = this->m_handlerFactory->getRoomManager();
	std::vector<Room> rooms = roomM->getRooms();
	
	response.rooms = rooms[request.roomId].getAllUsers();
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	res.next = this;
	return res;
}

RequestResult MenuRequestHandler::getStatistics(RequestInfo req)
{
	getStatisticsResponse response;
	RequestResult res;
	StatisticsManager* statsM = this->m_handlerFactory->getStatsManager();
	stats s = statsM->getStatistics(this->user->getUserName());
	response.statistics = s;
	response.status = success;
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	res.next = this;
	return res;
}

RequestResult MenuRequestHandler::joinRoom(RequestInfo req)
{
	JoinRoomResponse response;
	RequestResult res;
	JoinRoomRequest request = JsonRequestPacketDeserializer::deserializeJoinRoomRequest(req.buffer);
	RoomManager* roomM = this->m_handlerFactory->getRoomManager();
	roomM->addUser(request.roomId, *this->user);
	response.status = success;
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	std::vector<Room> rooms = roomM->getRooms();
	Room* room_ = new Room();
	for (Room & r : rooms)
	{
		if(r.getId() == request.roomId)
		{
			*room_ = r;
		}
	}
	res.next = this->m_handlerFactory->createRoomMemberRequestHandler(this->m_handlerFactory, this->user, room_); // change it to roomMember request later
	return res;

}

RequestResult MenuRequestHandler::createRoom(RequestInfo req)
{
	CreateRoomResponse response;
	RequestResult res;
	CreateRoomRequest request = JsonRequestPacketDeserializer::deserializeCreateRoomRequest(req.buffer);
	RoomManager* roomM = this->m_handlerFactory->getRoomManager();
	StatisticsManager* stats = this->m_handlerFactory->getStatsManager();
	//unsigned int id = stats->getId() + 1;
	unsigned int id = getRoomIdCount();
	MenuRequestHandler::roomIdCount++;
	/*unsigned int id, string name, int maxPlayers, unsigned int timePerQuestion, bool isActive*/
	RoomData data = {id,request.roomName,request.maxPlayers,request.answerTimeout,false };
	Room* room = new Room(data);
	roomM->createRoom(*(this->user), *room);
	roomM->addUser(id, *this->user);
	response.status = success;
	MenuRequestHandler::roomIdCount++;
	res.responce = JsonResponsePacketSerializer::serializeResponse(response);
	res.next = this->m_handlerFactory->createRoomAdminRequestHandler(this->m_handlerFactory,this->user,room); // change it to roomAdmin request later
	return res;
}
