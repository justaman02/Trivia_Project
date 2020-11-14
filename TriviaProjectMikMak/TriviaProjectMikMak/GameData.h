#pragma once
#include "Question.h"
struct GameData {
public:
	Question currentQuestion;
	unsigned int correctAnswerCount;
	unsigned int wrongAnswerCount;
	unsigned int averangeAnswerTime;
	unsigned int questionsCount;
};
