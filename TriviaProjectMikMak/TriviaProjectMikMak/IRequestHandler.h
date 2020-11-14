#pragma once
#include <vector>
#include <iostream>
#include "ServerEnum.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"
#include "LoggedUser.h"

struct RequestInfo
{
	int id;
	std::string recivalTime;
	const char* buffer;

};

struct RequestResult;
class IRequestHandler
{
public:
	virtual bool isRequestRelevant(RequestInfo req) = 0;
	virtual RequestResult handleRequest(RequestInfo req) = 0;
};

struct RequestResult
{
	std::vector<unsigned char> responce;
	IRequestHandler* next;
};



