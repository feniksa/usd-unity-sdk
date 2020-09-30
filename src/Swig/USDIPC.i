%module(directors="1") USDIPC

%define RPR_IPC_API %enddef

%{
  #include "../USDIPC/server.h"
%}

%include "../USDIPC/server.h"
