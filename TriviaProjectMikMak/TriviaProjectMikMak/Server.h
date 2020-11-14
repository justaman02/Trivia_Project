#pragma once
#include "Communicator.h"
#include <WinSock2.h>
#include <Windows.h>
#include <thread>
#include <iostream>
#include "JsonRequestPacketDeserializer.h"
using std::thread;
using std::cout;
using std::string;


class Server
{
private:
	RequestHandlerFactory m_handlerFactory;
	Communicator m_communicator;

public:
	void run();
};

