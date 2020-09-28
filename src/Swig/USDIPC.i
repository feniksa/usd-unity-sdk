%module USDIPC

%{
#include "usdDefines.h"
%}

%include "pxr/pxr.i"

%define RPR_IPC_API %enddef

%{
  #include "../USDIPC/server.h"
%}

%include "../USDIPC/server.h"