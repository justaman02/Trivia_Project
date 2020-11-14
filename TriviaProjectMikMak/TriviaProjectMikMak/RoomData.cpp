#include "RoomData.h"

RoomData::RoomData(unsigned int id, string name, unsigned int maxPlayers, unsigned int timePerQuestion, bool isActive)
{
	this->id = id;
	this->name = name;
	this->maxPlayers = maxPlayers;
	this->timePerQuestion = timePerQuestion;
	this->isActive = isActive;
}
