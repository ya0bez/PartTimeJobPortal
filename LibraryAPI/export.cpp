#include "pch.h"
#include "export.h"

long summ(const long a, const long b)
{
    return a + b;
}

const char* getName()
{
    std::string name = "test API";
    return name.c_str();
}