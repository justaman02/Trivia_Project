#include "SqliteDataBase.h"


/*
C'tor fot DB, initialize DB with tables
*/
SqliteDataBase::SqliteDataBase()
{
	std::string dbFileName = "trviaDB.sqlite";
	int doesFileExist = _access(dbFileName.c_str(), 0);
	int res = sqlite3_open(dbFileName.c_str(), &this->db);
	if (res != SQLITE_OK)
	{
		this->db = nullptr;
	}
	if (doesFileExist == -1)
	{
		try
		{
			std::string sqlStatement = "CREATE TABLE USERS(NAME TEXT,PASSWORD TEXT,EMAIL,  PRIMARY KEY(NAME)); ";
			char* errMessage = nullptr;
			res = sqlite3_exec(this->db, sqlStatement.c_str(), nullptr, nullptr, &errMessage);
			if (res != SQLITE_OK)
				throw::std::runtime_error("CREATE USER FAILD");
			sqlStatement = "CREATE TABLE QUESTIONS(QUESTION TEXT,A_ONE TEXT,A_TWO TEXT, A_THREE TEXT,A_CORRECT TEXT); ";
			errMessage = nullptr;
			res = sqlite3_exec(this->db, sqlStatement.c_str(), nullptr, nullptr, &errMessage);
			if (res != SQLITE_OK)
				throw::std::runtime_error("CREATE QUESTIONS FAILD");
			sqlStatement = "CREATE TABLE STATS(USER_NAME TEXT,ROOM_ID INTIGER,GAMES_PLAYED INTIGER, ANSWER_COUNT INTIGER ,CORRECT_COUNT INTIGER, AVEREGE_TIME FLOAT,  FOREIGN KEY(USER_NAME) REFERENCES USERS(NAME));";
			res = sqlite3_exec(this->db, sqlStatement.c_str(), nullptr, nullptr, &errMessage);
			if (res != SQLITE_OK)
				throw::std::runtime_error("CREATE STATS FAILD");
		}
		catch (std::exception e)
		{
			std::cout << e.what() << std::endl;
		}

	}

	vector<vector<string>> vec{ {"What colour is the circle on the Japanese flag?","White","Yellow","Black","red"},
								{"Which of the following former Yugoslavian states is landlocked?","Bosnia and Herzegovina","Montenegro","Croatia","Serbia"},
								{"How many time zones does China have?","3","4","2","1"},
								{"Which small country is located between the borders of France and Spain?","San Marino","Vatican City","Lichtenstein","Androrra"},
								{"Which country was NOT part of the Soviet Union?","Turkmenistan","Belarus","Tajikistan","Romania"},
								{"What is the capital of Scotland?","Glasgow","Dundee","London","Edinburgh"},
								{"what is the correct answer for 1+1?","1","3","4","2"},
								{"what is the color of dirt?","red","green","lol","brown"},
								{"where does trump lives?","israel","russia","germany","united states"},
								{"which name, isnt a city name in israel?","Tel-Aviv","Haifa","Rehovot","Hamburg"} };
	vector<vector<string>>::iterator it = vec.begin();
	for (it; it != vec.end(); it++)
	{
		char* errMessage = nullptr;
		std::ostringstream stream;
		stream << "INSERT INTO QUESTIONS(QUESTION, A_ONE, A_TWO, A_THREE, A_CORRECT) VALUES ('" << (*it)[0] << "','" << (*it)[1] << "','" << (*it)[2] << "','" << (*it)[3] << "','" << (*it)[4] << "');";
		std::string sqlStatement = stream.str();
		int res = sqlite3_exec(this->db, sqlStatement.c_str(), nullptr, nullptr, &errMessage);
		if (res != SQLITE_OK)
			throw::std::runtime_error("addQuestionFail");
	}
}

/*
The function checks if user exsits in the DB
param:
	@string: name (username)
output:
	#bool (exsits or not)
*/
bool SqliteDataBase::doesUserExists(string name)
{
	int exists = 0;
	char* errMessage = nullptr;
	std::ostringstream stream;
	stream << "SELECT COUNT(*) FROM USERS WHERE NAME = '" << name << "';";
	std::string sqlStatement = stream.str();
	sqlite3_exec(this->db, sqlStatement.c_str(), CountCallBack, &exists, &errMessage);
	if (exists >= 1)
	{
		this->userToCheck = name;
		return true;
	}
	return false;
}

/*
The function checks if user insert the right password for it's account
param:
	@string: password
output:
	#bool (match or not)
*/
bool SqliteDataBase::doesPasswordMatch(string password)
{
	int match = 0;
	char* errMessage = nullptr;
	std::ostringstream stream;
	stream << "SELECT COUNT(*) FROM USERS WHERE NAME = '" << this->userToCheck << "' AND PASSWORD = '" << password << "';";
	std::string sqlStatement = stream.str();
	sqlite3_exec(this->db, sqlStatement.c_str(), CountCallBack, &match, &errMessage);
	if (match >= 1)
	{
		return true;
	}
	return false;
}

/*
The function add new user to DB
param:
	@string: name (username), password, email
*/
void SqliteDataBase::addNewUser(string name, string password, string email)
{
	char* errMessage = nullptr;
	std::ostringstream stream;
	stream << "INSERT INTO USERS(NAME, PASSWORD, EMAIL) VALUES ('" << name << "','" << password << "','" << email << "');";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), nullptr, nullptr, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("addUserFail");
}

/* getters for DB */
string SqliteDataBase::getUserTGoCheck()
{
	return this->userToCheck;
}
void SqliteDataBase::setUserToCheck(string name)
{
	this->userToCheck = name;
}
vector<Question> SqliteDataBase::getQuestions()
{
	vector<Question> questions;
	char* errMessage = nullptr;
	float aTime = 0;
	std::ostringstream stream;
	stream << "SELECT * FROM QUESTIONS;";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), QuestionsCallBack, &questions, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("averge failed");
	return questions;
}
float SqliteDataBase::getPlayerAverageAnswerTime(string name)
{
	char* errMessage = nullptr;
	float aTime = 0;
	std::ostringstream stream;
	stream << "SELECT AVEREGE_TIME FROM STATS WHERE USER_NAME = '" << name << "';";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), selectNumberCallBack, &aTime, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("averge failed");
}
int SqliteDataBase::getNumOfCorrectAnswers(string name)
{
	char* errMessage = nullptr;
	int cAnswers = 0;
	std::ostringstream stream;
	stream << "SELECT CORRECT_COUNT FROM STATS WHERE USER_NAME = '" << name << "';";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), selectNumberCallBack, &cAnswers, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("averge failed");
}
int SqliteDataBase::getNumOfTotalAnswers(string name)
{
	char* errMessage = nullptr;
	int totalAnswers = 0;
	std::ostringstream stream;
	stream << "SELECT ANSWER_COUNT FROM STATS WHERE USER_NAME = '" << name << "';";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), selectNumberCallBack, &totalAnswers, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("averge failed");
}
int SqliteDataBase::getNumOfPlayerGames(string name)
{
	char* errMessage = nullptr;
	int games = 0;
	std::ostringstream stream;
	stream << "SELECT GAMES_PLAYED FROM STATS WHERE USER_NAME = '" << name << "';";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), selectNumberCallBack, &games, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("averge failed");
}
int SqliteDataBase::getSocre(string name,int roomId)
{
	char* errMessage = nullptr;
	stats statistics;
	int games = 0;
	std::ostringstream stream;
	stream << "SELECT * FROM STATS WHERE USER_NAME = '" << name << "''" << "AND ROOM_ID = '" << roomId <<"';";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), selectNumberCallBack, &statistics, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("score failed");
	return (statistics.correctCount * 15) - 1.5 * statistics.avargeTime;
}

map<string, int> SqliteDataBase::getScoreTable()
{
	map<string, int> scoreTable;
	char* errMessage = nullptr;
	float aTime = 0;
	std::ostringstream stream;
	stream << "SELECT USER_NAME,SCORE FROM STATS ORDER BY SCORE DESC LIMIT 5;";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), scoreCallBack, &scoreTable, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("averge failed");
	return scoreTable;

}

 int SqliteDataBase::LastId()
{
	char* errMessage = nullptr;
	int id  = 0;
	std::ostringstream stream;
	stream << "SELECT ROOM_ID from STATS order by ROOM_ID desc limit 1;";
	std::string sqlStatement = stream.str();
	int res = sqlite3_exec(this->db, sqlStatement.c_str(), selectNumberCallBack, &id, &errMessage);
	if (res != SQLITE_OK)
		throw::std::runtime_error("last id");
	return id;
}

/*---------------------------*/


/*
Callback function for count rows from DB
param:
	@callback standart params
output:
	#int: status code
*/
int CountCallBack(void* num, int count, char** data, char** columns)
{
	int* number = (int*)num;

	(*number) += std::stoi(string(data[0]));

	
	
	return 0;
}

int QuestionsCallBack(void* list, int count, char** data, char** columns)
{
	vector<Question>* questions = reinterpret_cast<vector<Question>*>(list);
	string question;
	vector<string> answers;
	for (int i = 0; i < count; i++)
	{

		if (string(columns[i]) == "QUESTION")
		{
			question = data[i];
		}
		else
		{
			answers.push_back(data[i]);
		}
	}
	questions->emplace_back(question, answers);
	return 0;
}

int scoreCallBack(void* list, int count, char** data, char** columns)
{
	map<string, int>* socreTable = reinterpret_cast<map<string, int>*>(list);
	string name;
	int score;
	for (int i = 0; i < count; i++)
	{
		if (string(columns[i]) == "USER_NAME")
		{
			name = data[i];
		}
		else if(string(columns[i]) == "SCORE")
		{
			score = std::stoi(data[i]);
		}
	}
	socreTable->emplace(name, score);
	return 0;
}

int selectNumberCallBack(void* str, int count, char** data, char** columns)
{
	float* selectReturn = (float*)str;
	for (int i = 0; i < count; i++)
	{
		(*selectReturn) += std::stof(string(data[i]));
	}
	return 0;
}

int statsCallBack(void* str, int count, char** data, char** columns)
{
	stats* u_stats = reinterpret_cast<stats*>(str);
	for (int i = 0; i < count; i++)
	{
		if (string(columns[i]) == "ANSWER_COUNT")
		{
			u_stats->answerCount = std::stoi(data[i]);
		}
		else if (string(columns[i]) == "CORRECT_COUNT")
		{
			u_stats->correctCount = std::stoi(data[i]);
		}
		else if (string(columns[i]) == "AVEREGE_TIME")
		{
			u_stats->avargeTime = std::stoi(data[i]);
		}

	}
	u_stats->gamesPlayed = 0;
	u_stats->score = 0;
	return 0;
}
