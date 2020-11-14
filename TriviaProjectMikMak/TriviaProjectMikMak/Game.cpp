#include "Game.h"

Game::Game(vector<string> users, vector<Question> questions)
{
	GameData game = { questions[0],0,0,0,1 };
	for (const string& user : users)
	{
		
		this->m_players.insert(std::make_pair(LoggedUser(user), game));
	}
	for (const Question& question : questions)
	{
		this->m_questions.push_back(question);
	}

	
}

Question Game::getQuestionForUser(LoggedUser user)
{
	Question q = Question(m_questions[this->m_players[user].questionsCount]); 
	this->m_players[user].currentQuestion = Question(q);
	this->m_players[user].questionsCount++;
	return q;

}

void Game::submitAnswer(LoggedUser& user,unsigned int answerId)
{
	this->m_players[user].questionsCount++;
	if (answerId == 3)
	{
		this->m_players[user].correctAnswerCount++;
	}
	else
	{
		this->m_players[user].wrongAnswerCount++;
	}
}
