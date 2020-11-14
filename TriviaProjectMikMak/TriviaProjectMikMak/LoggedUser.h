#pragma once
#include <iostream>
class LoggedUser
{
	std::string m_username;
public:
	LoggedUser(std::string name);
	bool operator==(const LoggedUser& other) const;
	bool operator< (const LoggedUser& other) const;
	std::string getUserName();
};

