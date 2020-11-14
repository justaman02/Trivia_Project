#include "Server.h"

/*
The function run the server
*/
void Server::run()
{
	m_handlerFactory = RequestHandlerFactory();
	m_communicator = Communicator();
	thread t_connector(&Communicator::startHandleRequests,&m_communicator,m_handlerFactory);
	t_connector.detach();
	string command;
	while (true && command != "EXIT")
	{
		std::cin >> command;
	}
}
