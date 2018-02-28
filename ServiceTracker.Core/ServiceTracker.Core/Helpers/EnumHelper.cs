using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core
{
    public enum Type
    {
        Monochrome = 0,
        Colored = 1
    }

    public enum Role
    {
        ADMINISTRATOR = 0,
        SERVICEENGINEER = 1,
        WORKCONTROLLER = 2
    }

    public enum ErrorCode
    {
        DEFAULT = 0,
        INVALID_INPUT = 100,
        DATA_NOT_FOUND = 200,
        NO_CHANGE = 300,
        NO_AVAILABLE_SPACE = 800,
        EXCEPTION = 999
    }
}