import socket
import json
import math

def bytes_needed(n):
    if n == 0:
        return 1
    return int(math.log(n, 256)) + 1

if __name__ == '__main__':
    TCP_IP = '127.0.0.1'
    TCP_PORT = 1111
    BUFFER_SIZE = 1024
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.connect((TCP_IP, TCP_PORT))

    protocol = ""
    choice = input("1 for login\n2 for signup\n Enter: ")
    if choice == '1':
        username = input("Enter username: ")
        password = input("Enter password: ")
        login_msg = {
            "username": username,
            "password": password
        }
        json_msg = json.dumps(login_msg)
        protocol += chr(1)
    elif choice == '2':
        username = input("Enter username: ")
        password = input("Enter password: ")
        mail = input("Enter mail: ")
        signup_msg = {
            "username": username,
            "password": password,
            "mail": mail
        }
        json_msg = json.dumps(signup_msg)
        protocol += chr(2)

    print("size of json is: " + str(len(json_msg)))
    print("how many bytes it's takes: " + str(bytes_needed(len(json_msg))))
    print((len(json_msg) >> 24) & 0xFF)
    print((len(json_msg) >> 16) & 0xFF)
    print((len(json_msg) >> 8) & 0xFF)
    print((len(json_msg)) & 0xFF)

    protocol += chr((len(json_msg) >> 24) & 0xFF)
    protocol += chr((len(json_msg) >> 16) & 0xFF)
    protocol += chr((len(json_msg) >> 8) & 0xFF)
    protocol += chr(len(json_msg) & 0xFF)

    protocol += json_msg
    print("protocol: " +protocol +"\n")
    print(protocol.encode)
    s.send(protocol.encode())
    msg = s.recv(1024).decode()
    
    print("Client connected secsessfully!\nThe server says: " + msg)
    input('press any key to exit...')
    s.close()
    print("socket closed!")
