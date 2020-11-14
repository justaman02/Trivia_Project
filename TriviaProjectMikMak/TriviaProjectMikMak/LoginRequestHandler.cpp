#include "LoginRequestHandler.h"
#include "responseCodeEnum.h"

/*
C'tor for Login request handler
params:
	@RequestHandlerFactory* handler (handler to RequestHandlerFactory)
*/
LoginRequestHandler::LoginRequestHandler(RequestHandlerFactory* handler)
{
	this->m_handlerFactory = handler;
}

/* 
The method check if the request that was given 
is relevant for the login request
params:
	@ RequestInfo req (struct with the request information)
output:
	#bool (relevant or not)
*/
bool LoginRequestHandler::isRequestRelevant(RequestInfo req)
{
	return req.id == Login || req.id == Register;
}

/*
The method process the information for the login handler
params:
	@ RequestInfo req (struct with the request information)
output:
	#RequestResult (struct with data for client)
*/
RequestResult LoginRequestHandler::handleRequest(RequestInfo req)
{
	int resCode = 0;
	
	LoginManager* loginM = this->m_handlerFactory->getLoginManager();
	RequestResult res{};
	

	if (req.id == Login)
	{
		
		res = this->login(req);
		
	}
	else if (req.id == Register)
	{
		res = this->signup(req);
	}

	
	return res;
}

/*
The method process the information about the login process
params:
	@ RequestInfo req (struct with the request information)
output:
	#RequestResult (struct with data for client)
*/
RequestResult LoginRequestHandler::login(RequestInfo req)
{
	int resCode = 0;
	RequestResult res{};
	LoginResponse response;
	LoginRequest loginReq;
	LoginManager* loginM = this->m_handlerFactory->getLoginManager();


	loginReq = JsonRequestPacketDeserializer::deserializeLoginRequest(req.buffer);
	std::cout << loginReq.username << " " << loginReq.password << " " << std::endl;
	resCode = loginM->login(loginReq.username, loginReq.password);

	response.status = resCode;
	std::vector<unsigned char> resBuff = JsonResponsePacketSerializer::serializeResponse(response);
	if (response.status == success)
	{	
		res.next = this->m_handlerFactory->createMenuRequestHandler(this->m_handlerFactory, new LoggedUser(loginReq.username));
	}
	else
	{
		res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory);
	}
	res.responce = resBuff;

	return res;
}

/*
The method process the information about the signup process
params:
	@ RequestInfo req (struct with the request information)
output:
	#RequestResult (struct with data for client)
*/
RequestResult LoginRequestHandler::signup(RequestInfo req)
{
	int resCode = 0;
	RequestResult res{};
	LoginResponse response;
	SignupRequest singupReq;
	LoginManager* loginM = this->m_handlerFactory->getLoginManager();
	


	singupReq = JsonRequestPacketDeserializer::deserializeSignupRequest(req.buffer);
	std::cout << singupReq.username << " " << singupReq.password << " " << singupReq.email << std::endl;
	resCode = loginM->signup(singupReq.username, singupReq.password, singupReq.email);

	response.status = resCode;
	if (response.status == success)
	{
		res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory);
	}
	else
	{
		res.next = this->m_handlerFactory->createLoginRequestHandler(this->m_handlerFactory); 
	}
	std::vector<unsigned char> resBuff = JsonResponsePacketSerializer::serializeResponse(response);
	res.responce = resBuff;
	return res;
}

