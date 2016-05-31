#ifndef FUNCS_H
#define FUNCS_H

#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>
#include <memory>

bool                    terminateProgram();
double*                 getDouble();
const std::string       getOperator();
void                    doMath(const std::string& strRefOperator, const double* ptrDouble1, const double* ptrDouble2);
void                    print (const std::string& strRefMessage);

#endif