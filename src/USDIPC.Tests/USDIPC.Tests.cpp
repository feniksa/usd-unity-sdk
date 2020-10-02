// USDIPC.Tests.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "server.h"

int main()
{
	pxr::RprIpcServer::Listener listener;
	pxr::RprIpcServer server(&listener);

	std::cout << "Hello World!\n";
}
