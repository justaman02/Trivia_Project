#pragma once
#define _CRT_SECURE_NO_WARNINGS
#include <string>
#include <bitset>
#include <algorithm>
#include "json.hpp"
#include "ServerEnum.h"
#include "RoomData.h"
#include "responseCodeEnum.h"
#include <vector>
#include "StaticsManger.h"

using nlohmann::json;
using std::vector;
using std::string;

/* Version 1 */
struct ErrorResponse {
	string massage;
};

struct LoginResponse {
	unsigned int status;
};

struct SignupResponse {
	unsigned int status;
};

/* --------------------------------------------------------------- */
/* Version 2 */
struct LogoutResponse {
	unsigned int status;
};

struct GetRoomsResponse {
	unsigned int status;
	vector<RoomData> rooms;
};

struct GetPlayersInRoomResponse {
	vector<std::string> rooms;
};

struct getStatisticsResponse {
	unsigned int status;
	stats statistics;
};

struct JoinRoomResponse {
	unsigned int status;
};

struct CreateRoomResponse {
	unsigned int status;
};
/*----------------------------------------------------*/
/* Version 3 */
struct CloseRoomResponse {
	unsigned int status;
};

struct StartGameResponse{
	unsigned int status;
};

struct LeaveRoomResponse{
	unsigned int status;
};

struct GetRoomStateResponse {
	unsigned int status;
	bool hasGameBegun;
	vector<string> players;
	unsigned int questionCount;
	unsigned int answerTimeout;
};
/* Version 4*/
struct LeaveGameResponse
{
	unsigned int status;
};
struct GetQuestionResponse
{
	unsigned int status;
	string question;
	map<string, string> answers;
};
struct SubmitAnswerResponse
{
	unsigned int status;
	unsigned int correctAnswerId;
};
struct PlayerResults
{
	string username;
	unsigned int correctAnswerCount;
	unsigned int wrongAnswerCount;
	unsigned int averageAnswerTime;
};
struct GetGameResultsResponse
{
	unsigned int status;
	std::vector<PlayerResults> results;
};






/*--------------------------------------------*/
void to_json(json& j, const RoomData& p);
void to_json(json& j, const stats& p);
void to_json(json& j, const PlayerResults& p);
class JsonResponsePacketSerializer
{	
public:
	/* Version 1 */
	static vector<unsigned char> serializeResponse(ErrorResponse);
	static vector<unsigned char> serializeResponse(LoginResponse);
	static vector<unsigned char> serializeResponse(SignupResponse);

	/* Version 2 */
	static vector<unsigned char> serializeResponse(LogoutResponse);
	static vector<unsigned char> serializeResponse(GetRoomsResponse);
	static vector<unsigned char> serializeResponse(GetPlayersInRoomResponse);
	static vector<unsigned char> serializeResponse(getStatisticsResponse);//TODO - Not sure yet how to do that
	static vector<unsigned char> serializeResponse(JoinRoomResponse);
	static vector<unsigned char> serializeResponse(CreateRoomResponse);

	/* Version 3 */
	static vector<unsigned char> serializeResponse(CloseRoomResponse);
	static vector<unsigned char> serializeResponse(StartGameResponse);
	static vector<unsigned char> serializeResponse(LeaveRoomResponse);
	static vector<unsigned char> serializeResponse(GetRoomStateResponse);

	/* Version 4*/

	static vector<unsigned char> serializeResponse(GetGameResultsResponse);
	static vector<unsigned char> serializeResponse(SubmitAnswerResponse);
	static vector<unsigned char> serializeResponse(GetQuestionResponse);
	static vector<unsigned char> serializeResponse(LeaveGameResponse);

private:
	static vector<unsigned char> buildMessage(json, MessageTypes);
};

