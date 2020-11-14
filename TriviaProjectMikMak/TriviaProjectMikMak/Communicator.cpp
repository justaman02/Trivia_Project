#include "Communicator.h"
#include "Helper.h"
#include "JsonRequestPacketDeserializer.h"
#include "JsonResponsePacketSerializer.h"

/*
The method binding the socket and listen fot clients
*/
void Communicator::bindAndListen()
{
	this->_socket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (_socket == INVALID_SOCKET)
	{
		std::cout << GetLastError();
		throw std::exception(__FUNCTION__ " - socket");
	}
	struct sockaddr_in sa = { 0 };
	sa.sin_port = htons(PORT);
	sa.sin_family = AF_INET;
	sa.sin_addr.s_addr = IFACE;
	// again stepping out to the global namespace
	if (::bind(_socket, (struct sockaddr*) & sa, sizeof(sa)) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - bind");


	if (::listen(_socket, SOMAXCONN) == SOCKET_ERROR)
		throw std::exception(__FUNCTION__ " - listen");

}

/*
The method handling new client
params:
	@ SOCKET clientSocket 
*/
void Communicator::handleNewClient(SOCKET clientSocket)
{
	int disconnected = false;
	RequestInfo req;
	try
	{
		while (true && !disconnected)
		{
			RequestResult res;
			MessageTypes msgType = static_cast<MessageTypes>(Helper::getMessageTypeCode(clientSocket));
			req.id = msgType;
			req.recivalTime = Helper::getDataNow();
			int jsonSize = Helper::getJsonSize(clientSocket);
			cout << "size:" << jsonSize << endl;
			std::string buffer = Helper::getStringPartFromSocket(clientSocket, jsonSize);
			std::cout << "buffer:" << buffer << std::endl;
			req.buffer = buffer.c_str();
			switch (msgType)
			{
			/* case for login and register is the same for right now */
			case Login:
			case Register:
			{
				if (m_clients.at(clientSocket)->isRequestRelevant(req))
				{
					res = m_clients.at(clientSocket)->handleRequest(req);
				}
				else
				{
					ErrorResponse response;
					std::vector<unsigned char> buff = JsonResponsePacketSerializer::serializeResponse(response);
					Helper::sendData(clientSocket, std::string(buff.begin(),buff.end()));
					break;
				}
				//LoginRequest deLogin= JsonRequestPacketDeserializer::deserializeLoginRequest(buffer.c_str());
				
					

				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case logout:
			{
				res = m_clients.at(clientSocket)->handleRequest(req);
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case CreateRoom:
			{
				res = m_clients.at(clientSocket)->handleRequest(req);
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case GetRooms:
			{
				res = m_clients.at(clientSocket)->handleRequest(req);
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case startGameResponse:
			{	
				
				res = m_clients.at(clientSocket)->handleRequest(req);
				
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				
				
				req.id = startGameResponse;
				for (auto& p : this->m_clients)
				{
					if (RoomMemberRequestHandler* temp =  dynamic_cast<RoomMemberRequestHandler*>(p.second))
					{
						if (temp->m_room->getId() == dynamic_cast<RoomAdminRequestHandler*>(this->m_clients[clientSocket])->m_room->getId())
						{
							std::cout << std::endl <<"client:" << p.first << "started" <<  std::endl;
							StartGameResponse r;
							r.status = success;
							res.responce = JsonResponsePacketSerializer::serializeResponse(r);
							res.next = this->m_handlerFactory.createGameRequestHandler(&this->m_handlerFactory, temp->m_user, temp->m_room, this->m_handlerFactory.getGameManager()->getLastGame());
							std::string Buff(res.responce.begin(), res.responce.end());
							Helper::sendData(p.first, Buff);
							m_clients[p.first] = res.next;
						}
					}

				}
				m_clients[clientSocket] = res.next;
				break;
			}
			case JoinRoom:
			{
				res = m_clients.at(clientSocket)->handleRequest(req);
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case getRoomStateResponse:
			{
				if (m_clients.at(clientSocket) == nullptr)
				{
					std::cout << "was nullptr" << std::endl;
					break;
				}
				res = m_clients.at(clientSocket)->handleRequest(req);

				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case getquestion:
			{
				res = m_clients.at(clientSocket)->handleRequest(req);
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
			case submitanswer:
			{
				res = m_clients.at(clientSocket)->handleRequest(req);
				std::string sendBuff(res.responce.begin(), res.responce.end());
				Helper::sendData(clientSocket, sendBuff);
				m_clients[clientSocket] = res.next;
				break;
			}
				
			default:
				//client disconnected, stop reciving data
				cout << "got here!!!";
				disconnected = true;
				break;
			}

		}
	}
	catch (const std::exception & e)
	{
		std::cout << "Exception was catch in function clientHandler. socket=" << clientSocket << ", what=" << e.what() << std::endl;
	}
	//delete client and close socket
	req.id = logout;
	m_clients.at(clientSocket)->handleRequest(req);
	m_clients.erase(clientSocket);
	std::cout << "socket:" << clientSocket << "closed" << std::endl;
	closesocket(clientSocket);
}


void Communicator::startHandleRequests(RequestHandlerFactory handlerFactory)
{
	this->m_handlerFactory = handlerFactory;
	//SOCKET client_socket;
	this->bindAndListen();
	std::cout << "Listening" << std::endl;
	while (true)
	{
		// the main thread is only accepting clients 
		// and add then to the list of handlers
		this->acceptClient();

	}
}
void Communicator::acceptClient()
{
	SOCKET client_socket = accept(_socket, NULL, NULL);
	if (client_socket == INVALID_SOCKET)
		throw std::exception(__FUNCTION__);
	std::cout << "socket:" << client_socket << "accepted" << std::endl;
	IRequestHandler* newLoginRequest = m_handlerFactory.createLoginRequestHandler(&m_handlerFactory);
	this->m_clients[client_socket] = newLoginRequest;
	std::thread tr(&Communicator::handleNewClient, this, client_socket);
	tr.detach();

}


