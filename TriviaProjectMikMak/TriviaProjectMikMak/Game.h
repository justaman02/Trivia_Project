#pragma once
#include "Question.h"
#include <vector>
#include "LoggedUser.h"
#include "GameData.h"
#include "StaticsManger.h"
#include <map>
using std::vector;
using std::map;
class Game
{
private:
	vector<Question> m_questions;
	map<LoggedUser ,GameData> m_players;
public:
	Game(vector<string> users,vector<Question>);
	Question getQuestionForUser(LoggedUser);
	void submitAnswer(LoggedUser&, unsigned int answerId);
	void removePlayer();
};

