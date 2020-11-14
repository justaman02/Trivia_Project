#pragma once
#include <map>
#include "Room.h"
#include "LoggedUser.h"

using std::map;
class RoomManager
{
public:
	void createRoom(LoggedUser, Room);
	void deleteRoom(int ID);
	GetRoomStateResponse  getRoomState(int ID);
	vector<Room> getRooms();
	void addUser(int id,LoggedUser user);
	void setRoomState(int id,bool started);
	void leaveRoom(int id,LoggedUser user);

private:
	map<int, Room> m_rooms;
};
