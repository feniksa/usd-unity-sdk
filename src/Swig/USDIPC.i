%module USDIPC

%define WIN32_LEAN_AND_MEAN %enddef

%{
#include "usdDefines.h"
%}

%include "pxr/pxr.i"
%define RPR_IPC_API %enddef

%{
  #include "winsock2.h"
  #include "../USDIPC/server.h"
%}

%include "../USDIPC/server.h"