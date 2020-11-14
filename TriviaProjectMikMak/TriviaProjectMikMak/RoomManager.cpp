#include "RoomManager.h"

void RoomManager::createRoom(LoggedUser user, Room room)
{
	if (!this->m_rooms.insert(std::make_pair(room.getId(), room)).second) {
		
	}
}

void RoomManager::deleteRoom(int ID)
{
	this->m_rooms.erase(ID);
}

GetRoomStateResponse RoomManager::getRoomState(int ID)
{
	return this->m_rooms.at(ID).getRoomState();
}

vector<Room> RoomManager::getRooms()
{
	vector<Room> temp;
	for (auto room : this->m_rooms)
	{
		temp.push_back(room.second);
	}
	return temp;
}

void RoomManager::addUser(int id, LoggedUser user)
{
	this->m_rooms[id].addUser(user);
}

void RoomManager::setRoomState(int id,bool started)
{
	this->m_rooms[id].setRoomState(started);
}

void RoomManager::leaveRoom(int id,LoggedUser user)
{
	m_rooms[id].removeUser(user);
}
