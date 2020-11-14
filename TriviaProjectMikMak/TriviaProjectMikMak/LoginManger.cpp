#include "LoginManger.h"

/*
C'tor for LoginManager
*/
LoginManager::LoginManager()
{
	this->m_database = new SqliteDataBase();
}

/*
The method signup the client for the game
params:
	@ String: name, password, email
output:
	#Int: status code for signup (See ServerEnum.h for all codes)
*/
int LoginManager::signup(string name, string password, string email)
{
	if(m_database->doesUserExists(name))
	{
		return nameExsits;//name taken
	}
	m_database->addNewUser(name, password, email);
	return success;//signup succeed


}

/*
The method login the client for the game
params:
	@ String: name, password
output:
	#Int: status code for login (See ServerEnum.h for all codes)
*/
int LoginManager::login(string name, string password)
{
	std::vector<LoggedUser>::iterator it = this->m_loggedUser.begin();
	
	if(m_database->doesUserExists(name))
	{
		if (m_database->doesPasswordMatch(password))
		{
			it = this->m_loggedUser.begin();
			for (it; it != this->m_loggedUser.end(); it++)
			{
				if (it->getUserName() == name)
				{
					return alreadyConnected;
				}
			}
			LoggedUser newUser = LoggedUser(name);
			m_loggedUser.push_back(newUser);
			it = this->m_loggedUser.begin();
			std::cout << "Loggged users:" << std::endl;
			for (it; it != this->m_loggedUser.end(); it++)
			{
				std::cout << it->getUserName() << std::endl;
			}
			return success;//login succeed
			
		}
		std::cout << "Loggged users:" << std::endl;
		it = this->m_loggedUser.begin();
		for (it; it != this->m_loggedUser.end(); it++)
		{
			std::cout << it->getUserName() << std::endl;
		}
		return wrongPassword;//wrong password
	}
	std::cout << "Loggged users:" << std::endl;
	it = this->m_loggedUser.begin();
	for (it; it != this->m_loggedUser.end(); it++)
	{
		std::cout << it->getUserName() << std::endl;
	}
	return invalidName;//invalid name
}

/*
The method logout the client for the game
params:
	@ String: name
output:
	#Int: status code for logout (See ServerEnum.h for all codes)
*/
int LoginManager::logout(string name)
{
	vector<LoggedUser>::iterator it = m_loggedUser.begin();
	for (it; it != m_loggedUser.end(); it++)
	{
		if (it->getUserName() == name)
		{
			m_loggedUser.erase(it);
			return success;//logout succeed
		}
	}
	return userNotConnected;//user isnt connecced,  logout failed
}

