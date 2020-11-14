#include "Helper.h"


using std::string;

const char* Helper::getJsonData(SOCKET sc)
{
	return nullptr;
}

int Helper::getJsonSize(SOCKET sc)
{
	char* s = getPartFromSocket(sc, 4);//4 bytes

	int res = int((unsigned char)(s[0]) << 24 |
		(unsigned char)(s[1]) << 16 |
		(unsigned char)(s[2]) << 8 |
		(unsigned char)(s[3]));
	delete s;
	return  res;
}

// recieves the type code of the message from socket (3 bytes)
// and returns the code. if no message found in the socket returns 0 (which means the client disconnected)
int Helper::getMessageTypeCode(SOCKET sc)
{
	char* s = getPartFromSocket(sc, 1);//need just the first byte
	std::string msg(s);

	if (msg == "")
		return 0;

	int res = (int)*s;
	delete s;
	return  res;
}


// recieve data from socket according byteSize
// returns the data as int
int Helper::getIntPartFromSocket(SOCKET sc, int bytesNum)
{
	char* s = getPartFromSocket(sc, bytesNum, 0);
	return atoi(s);
}

// recieve data from socket according byteSize
// returns the data as string
string Helper::getStringPartFromSocket(SOCKET sc, int bytesNum)
{
	char* s = getPartFromSocket(sc, bytesNum, 0);
	string res(s);
	return res;
}

// return string after padding zeros if necessary
string Helper::getPaddedNumber(int num, int digits)
{
	std::ostringstream ostr;
	ostr << std::setw(digits) << std::setfill('0') << num;
	return ostr.str();

}

std::string Helper::bytesConverator(const char* bytes)
{
	string bytesStr(bytes);
	string output = "";
	std::stringstream sstream(bytesStr);
	while (sstream.good())
	{
		std::bitset<8> bits;
		sstream >> bits;
		cout << bits << endl;
		char c = char(bits.to_ulong());
		output += c;
		cout << output << endl;
	}
	return output;
}

std::string Helper::getDataNow()
{
	time_t now = time(nullptr);
	std::stringstream oss;
	oss << std::put_time(localtime(&now), "%d/%m/%Y %H:%M:%S");
	return oss.str();
}

// recieve data from socket according byteSize
// this is private function
char* Helper::getPartFromSocket(SOCKET sc, int bytesNum)
{
	return getPartFromSocket(sc, bytesNum, 0);
}

char* Helper::getPartFromSocket(SOCKET sc, int bytesNum, int flags)
{
	if (bytesNum == 0)
	{
		return (char*)"";
	}

	char* data = new char[bytesNum + 1];
	int res = recv(sc, data, bytesNum, flags);

	if (res == INVALID_SOCKET)
	{
		std::string s = "Error while recieving from socket: ";
		s += std::to_string(sc);
		throw std::exception(s.c_str());
	}

	data[bytesNum] = 0;
	return data;
}

// send data to socket
// this is private function
void Helper::sendData(SOCKET sc, std::string message)
{
	const char* data = message.c_str();

	if (send(sc, data, message.size(), 0) == INVALID_SOCKET)
	{
		throw std::exception("Error while sending message to client");
	}
}