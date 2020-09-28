%module USDIPC

%{
#include "usdDefines.h"
%}

%include "pxr/pxr.i"

%{
  #include "../USDIPC/server.h"
%}

%include "../USDIPC/server.h"