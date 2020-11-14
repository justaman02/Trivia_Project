#pragma once
typedef enum MessageTypes {
	Login = 1,
	Register ,
	Error ,
	CreateRoom ,
	GetRooms ,
	GetPlayers ,
	JoinRoom ,
	getStats ,
	logout ,
	noRooms ,
	roomResponse,
	playersInRoomResponse,
	statisticsResponse,
	joinRoomResponse,
	createRoomResponse,
	closeRoomResponse,
	startGameResponse,
	leaveRoomResponse,
	getRoomStateResponse,
	leaveGame,
	getquestion,
	submitanswer,
	getResults


} ReturnTypes;