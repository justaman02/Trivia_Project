#include "LoggedUser.h"

LoggedUser::LoggedUser(std::string name)
{
	this->m_username = name;
}

bool LoggedUser::operator==(const LoggedUser& other) const
{
	if (m_username == other.m_username)
	{
		return true;
	}
	else
	{
		return false;
	}
}

bool LoggedUser::operator<(const LoggedUser& other) const
{
	return (this->m_username < other.m_username);
}


std::string LoggedUser::getUserName()
{
	return this->m_username;
}
