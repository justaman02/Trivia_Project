#pragma comment (lib, "ws2_32.lib")
#include <winsock2.h>
#include "WSAInitializer.h"
#include <fstream>
#include "Server.h"
#include <iostream>
#include <exception>

int main()
{
	std::ifstream config;
	config.open("config.txt", std::ios_base::app);
	string ipAddr, port, temp;

	/* get the ip address */
	std::getline(config, temp);
	ipAddr = temp.substr(10);
	temp.clear();

	/* get the port */
	std::getline(config, temp);
	port = temp.substr(5);
	try
	{
		WSAInitializer wsaInit;
		Server myServer;

		myServer.run();
	
	}
	catch (std::exception & e)
	{
		std::cout << "Error occured: " << e.what() << std::endl;
	}
	return 0;
}