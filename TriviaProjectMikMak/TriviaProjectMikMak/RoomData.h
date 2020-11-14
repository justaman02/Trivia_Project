#pragma once
#include <string>

using std::string;

struct RoomData
{
public:
    RoomData() {}
    RoomData(unsigned int id, string name, unsigned int maxPlayers, unsigned int timePerQuestion, bool isActive);
    unsigned int id;
    string name;
    unsigned int maxPlayers;
    unsigned int timePerQuestion;
    bool isActive;
};