#include "Room.h"



Room::Room(RoomData data)
{
	this->m_metadata = data;
}

void Room::addUser(LoggedUser user)
{
	this->m_users.push_back(user);
}

void Room::removeUser(LoggedUser user)
{
	this->m_users.erase(std::remove(m_users.begin(), m_users.end(), user), m_users.end());
}

unsigned int Room::getId() const
{
	return this->m_metadata.id;
}

GetRoomStateResponse Room::getRoomState() const
{
	GetRoomStateResponse state;
	vector<string> players;
	for (auto player : this->m_users)
	{
		players.push_back(player.getUserName());
	}
	state.players = players;
	state.hasGameBegun = this->m_metadata.isActive;
	state.answerTimeout = this->m_metadata.timePerQuestion;
	state.questionCount = 10;
	state.status = 1;
	return state;
}

RoomData Room::getAllRoomData()
{
	return this->m_metadata;
}

void Room::setRoomState(bool started)
{
	this->m_metadata.isActive = started;
}

vector<string> Room::getAllUsers() const
{
	vector<string> retUsers;
	for (LoggedUser user : this->m_users)
	{
		retUsers.push_back(user.getUserName());
	}
	return retUsers;
}
