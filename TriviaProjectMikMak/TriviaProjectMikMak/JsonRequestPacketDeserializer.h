#pragma once
#include "map"
#include "iostream"
#include "string"
#include <algorithm>
#include "Helper.h"
#include "json.hpp"
using json = nlohmann::json;
using std::cout;
using std::string;
using std::endl;
using std::map;

/* Version 1 */
typedef struct LoginRequest
{
	std::string username;
	std::string password;
}LoginRequest;
typedef struct SignupRequest
{
	std::string username;
	std::string password;
	std::string email;
}SignupRequest;
/*----------------------------------------*/
/* Version 2 */

struct GetPlayersInRoomRequest {
	unsigned int roomId;
};

struct JoinRoomRequest {
	unsigned int roomId;
};

struct CreateRoomRequest {
	string roomName;
	unsigned int maxPlayers;
	unsigned int questionCount;
	unsigned int answerTimeout;
};

/*------------------------------------------*/
/* Version 4 */
struct SubmitAnswerRequest 
{
	unsigned int answerId;
};


class JsonRequestPacketDeserializer
{
public:
	static LoginRequest deserializeLoginRequest(const char* Buffer);
	static SignupRequest deserializeSignupRequest(const char* Buffer);
	static GetPlayersInRoomRequest deserializeGetPlayersRequest(const char* Buffer);
	static JoinRoomRequest deserializeJoinRoomRequest(const char* Buffer);
	static CreateRoomRequest deserializeCreateRoomRequest(const char* Buffer);
	static SubmitAnswerRequest deserializerSubmitAnswerRequest(const char* Buffer);
};

