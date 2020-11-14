#pragma once
#include "IDataBase.h"
#include "responseCodeEnum.h"
#include "SqliteDataBase.h"
#include <stdio.h>
#include <vector>
#include "LoggedUser.h"
#include <regex>
#include <algorithm>
using std::vector;
using std::string;
using std::regex;

class LoginManager
{
	IDataBase* m_database;
	vector<LoggedUser> m_loggedUser;
public:
	LoginManager();
	int signup(string name, string password, string email);
	int login(string name, string password);
	int logout(string name);
	
};