#pragma once
#include <vector>
#include <string>
#include <algorithm>
#include "RoomData.h"
#include "LoggedUser.h"
#include "JsonResponsePacketSerializer.h"

using std::vector;
using std::string;

class Room
{
public:
	Room() {}
	Room(RoomData);
	void addUser(LoggedUser);
	void removeUser(LoggedUser);
	vector<string> getAllUsers() const;
	unsigned int getId() const;
	GetRoomStateResponse getRoomState() const;
	RoomData getAllRoomData();
	void setRoomState(bool started);

private:
	RoomData m_metadata;
	vector<LoggedUser> m_users;
};

