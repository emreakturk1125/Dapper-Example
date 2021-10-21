using System;
using System.Collections.Generic;
using System.Text;

namespace DapperWebAPI.Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
