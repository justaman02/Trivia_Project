#include "JsonResponsePacketSerializer.h"

/*
This function is serialize the Error message type
Input:
	@error: ErrorResponse
Output:
	#buffer: vector<unsigned char> also known as a binary buffer
*/
vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(ErrorResponse error)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["message"] = error.massage;
	
	buffer = buildMessage(messageData, MessageTypes::Error);
	return buffer;
}

/*
This function is serialize the Login message type
Input:
	@login: LoginResponse
Output:
	#buffer: vector<unsigned char> also known as a binary buffer
*/
vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(LoginResponse login)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = login.status;

	buffer = buildMessage(messageData, MessageTypes::Login);
	return buffer;
}

/*
This function is serialize the Signup message type
Input:
	@signup: SignupResponse
Output:
	#buffer: vector<unsigned char> also known as a binary buffer
*/
vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(SignupResponse signup)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = signup.status;

	buffer = buildMessage(messageData, MessageTypes::Register);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(LogoutResponse logout)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = logout.status;

	buffer = buildMessage(messageData, MessageTypes::logout);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(GetRoomsResponse rooms)
{
	vector<unsigned char> buffer;
	json messageData;
	string roomStr = "";
	string rooms_vec;
	messageData["status"] = rooms.status;
	messageData["rooms"] = rooms.rooms;

	buffer = buildMessage(messageData, MessageTypes::roomResponse);
	return buffer;
	
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(GetPlayersInRoomResponse players)
{
	vector<unsigned char> buffer;
	json messageData;
	string roomStr = "";
	
	messageData["PlayersInRoom"] = players.rooms;

	buffer = buildMessage(messageData, MessageTypes::playersInRoomResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(getStatisticsResponse stats)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["stats"] = stats.statistics;
	buffer = buildMessage(messageData, MessageTypes::statisticsResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(JoinRoomResponse joinRoom)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = joinRoom.status;

	buffer = buildMessage(messageData, MessageTypes::JoinRoom);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(CreateRoomResponse createRoom)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = createRoom.status;

	buffer = buildMessage(messageData, MessageTypes::createRoomResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(CloseRoomResponse closeResp)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = closeResp.status;

	buffer = buildMessage(messageData, MessageTypes::closeRoomResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(StartGameResponse startResp)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = startResp.status;

	buffer = buildMessage(messageData, MessageTypes::startGameResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(LeaveRoomResponse leaveResp)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = leaveResp.status;

	buffer = buildMessage(messageData, MessageTypes::leaveRoomResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(GetRoomStateResponse roomStateResp)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = roomStateResp.status;
	messageData["answerTimeout"] = roomStateResp.answerTimeout;
	messageData["hasGameBegun"] = roomStateResp.hasGameBegun;
	messageData["players"] = roomStateResp.players;
	messageData["questionCount"] = roomStateResp.questionCount;

	buffer = buildMessage(messageData, MessageTypes::getRoomStateResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(GetGameResultsResponse result)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = result.status;
	messageData["results"] = result.results;

	buffer = buildMessage(messageData, MessageTypes::getRoomStateResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(SubmitAnswerResponse answer)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = answer.status;
	messageData["results"] = answer.correctAnswerId;

	buffer = buildMessage(messageData, MessageTypes::getRoomStateResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(GetQuestionResponse question)
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = question.status;
	messageData["question"] = question.question;
	messageData["answers"] = question.answers;


	buffer = buildMessage(messageData, MessageTypes::getRoomStateResponse);
	return buffer;
}

vector<unsigned char> JsonResponsePacketSerializer::serializeResponse(LeaveGameResponse leave )
{
	vector<unsigned char> buffer;
	json messageData;

	messageData["status"] = leave.status;

	buffer = buildMessage(messageData, MessageTypes::leaveRoomResponse);
	return buffer;
}

/*
This function is bulifing the serialize message acorrding to the message protocol.
Protocol:
  BYTE       4 BYTES      data size
[Msg type] [data size]  [DATA.......]
Input:
	@messageData: json
	@type: MessageTypes(enum)
Output:
	#buffer: vector<unsigned char> also known as a binary buffer
*/
vector<unsigned char> JsonResponsePacketSerializer::buildMessage(json messageData, MessageTypes type)
{
	const int byte = 1;
	const int fourBytes = 4;
	vector<unsigned char> buffer;
	int jsonLength = 0;
	string tempStr;

	/* Message variables */
	unsigned char dataLenghtBytes[4] = { 0 };// 4 bytes
	unsigned char messageCode =  (unsigned char)type ;// 1 byte
	unsigned char* messageDataBytes;// json message

	tempStr = messageData.dump();
	jsonLength = tempStr.length();

	/* Convert the json to binary (unsigned char array) */
	messageDataBytes = new unsigned char[tempStr.length() + 1];
	strcpy((char*)messageDataBytes, tempStr.c_str());

	/* Convert the size of the json to binary (unsigned char arr)*/
	dataLenghtBytes[0] = (jsonLength >> 24) & 0xFF;
	dataLenghtBytes[1] = (jsonLength >> 16) & 0xFF;
	dataLenghtBytes[2] = (jsonLength >> 8) & 0xFF;
	dataLenghtBytes[3] = jsonLength & 0xFF;


	/* pushing the bytes to the buffer */
	buffer.push_back(messageCode);//first byte

	for (int i = 0; i < fourBytes; i++)//next 4 bytes
	{
		buffer.push_back(dataLenghtBytes[i]);
	}

	for (int i = 0; i < jsonLength; i++)//json data
	{
		buffer.push_back(messageDataBytes[i]);
	}
	delete[] messageDataBytes;

	return buffer;
}
void to_json(json& j, const RoomData& p)
{
	j = { {"id", p.id}, {"name", p.name}, {"maxPlayers", p.maxPlayers} , {"timePerQuestion", p.timePerQuestion} , {"isActive", p.isActive} };
}

void to_json(json& j, const stats& p)
{

	j = { {"answerCount", p.answerCount}, {"avargeTime", p.avargeTime}, {"correctCount", p.correctCount} , {"gamesPlayed", p.gamesPlayed} , {"score",p.score} };
}

void to_json(json& j, const PlayerResults& p)
{
	j = { {"averageAnswerTime", p.averageAnswerTime}, {"correctAnswerCount", p.correctAnswerCount}, {"username", p.username} , {"wrongAnswerCount", p.wrongAnswerCount} };
}
