#pragma once
#include "Handlers.h"
#include "IRequestHandler.h"



class RequestHandlerFactory;
class LoginRequestHandler : public IRequestHandler
{
public:
	LoginRequestHandler(RequestHandlerFactory* handler);
	bool isRequestRelevant(RequestInfo req);
	RequestResult handleRequest(RequestInfo req);

private:
	RequestHandlerFactory* m_handlerFactory ;

	RequestResult login(RequestInfo);
	RequestResult signup(RequestInfo);

};

