#pragma once

#include "IRequestHandler.h"
#include "LoginRequestHandler.h"
#include "RequestHandlerFactory.h"
#include <map>
#include <WinSock2.h>
#include <Windows.h>
#include <thread>
#include <iostream>
#include <exception>
#include <string>


using std::map;
using std::cout;
using std::endl;
using std::string;

static const unsigned short PORT = 1234;
static const unsigned int IFACE = 0;

class Communicator
{
	map<SOCKET, IRequestHandler*> m_clients;
	SOCKET _socket;
	RequestHandlerFactory m_handlerFactory;

	void bindAndListen();
	void handleNewClient(SOCKET clientSocket);
	void acceptClient();
	
public:
	void startHandleRequests(RequestHandlerFactory handlerFactory);
};

