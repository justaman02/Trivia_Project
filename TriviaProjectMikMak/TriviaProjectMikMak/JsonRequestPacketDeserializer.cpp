#include "JsonRequestPacketDeserializer.h"
#include <bitset>

/*
The method deserialize login request and convert it to LoginRequest
params:
	@ const char*: buffer (buffer with client data)
output:
	#LoginRequest
*/
LoginRequest JsonRequestPacketDeserializer::deserializeLoginRequest(const char* Buffer)
{
	LoginRequest req;
	const std::string output(Buffer);

	//parse string in json format to json object
	auto j = json::parse(output);
	std::cout << j.dump(4) << std::endl;
	//fill request fields with the json values
	req.username = j["username"];
	req.password = j["password"];
	
	return req;
}

/*
The method deserialize signup request and convert it to SignupRequest
params:
	@ const char*: buffer (buffer with client data)
output:
	#SignupRequest
*/
SignupRequest JsonRequestPacketDeserializer::deserializeSignupRequest(const char* Buffer)
{
	SignupRequest req;
	const std::string output(Buffer);

	auto j = json::parse(output);
	std::cout << j.dump(4) << std::endl;
	//fill request fields with the json values
	req.username = j["username"];
	req.password = j["password"];
	req.email = j["mail"];
	return req;
}

GetPlayersInRoomRequest JsonRequestPacketDeserializer::deserializeGetPlayersRequest(const char* Buffer)
{
	GetPlayersInRoomRequest req;
	const std::string output(Buffer);

	auto j = json::parse(output);
	std::cout << j.dump(4) << std::endl;

	req.roomId = j["roomId"];
	return req;
}

JoinRoomRequest JsonRequestPacketDeserializer::deserializeJoinRoomRequest(const char* Buffer)
{
	JoinRoomRequest req;
	const std::string output(Buffer);

	auto j = json::parse(output);
	std::cout << j.dump(4) << std::endl;

	req.roomId = j["roomId"];
	return req;
}

CreateRoomRequest JsonRequestPacketDeserializer::deserializeCreateRoomRequest(const char* Buffer)
{
	CreateRoomRequest req;
	const std::string output(Buffer);

	auto j = json::parse(output);
	std::cout << j.dump(4) << std::endl;

	req.roomName = j["roomName"];
	req.maxPlayers = j["maxPlayers"];
	req.questionCount = j["questionCount"];
	req.answerTimeout = j["answerTimeout"];

	return req;
}

SubmitAnswerRequest JsonRequestPacketDeserializer::deserializerSubmitAnswerRequest(const char* Buffer)
{
	SubmitAnswerRequest req;
	const std::string output(Buffer);

	auto j = json::parse(output);
	std::cout << j.dump(4) << std::endl;

	req.answerId = j["answerId"];
	return req;

}
