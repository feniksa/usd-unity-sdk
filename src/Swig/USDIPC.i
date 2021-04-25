%module USDIPC

%define RPR_IPC_API %enddef

%{
  #include "../USDIPC/server.h"
%}

%include "layerformat.i"
%include "../USDIPC/server.h"



