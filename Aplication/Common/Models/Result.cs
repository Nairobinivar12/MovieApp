using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication.Common.Enums;
namespace Aplication.Common.Models
{
    public class Result
    {
        internal Result(bool succeeded, ResultsCodeEnum code, IEnumerable<string>? errors, string message, object? data)
        {
            Succeeded = succeeded;
            Errors = errors?.ToArray();
            Code = code;
            Data = data;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public ResultsCodeEnum Code { get; set; }
        public string Message { get; set; }
        public string[]? Errors { get; set; }
        public object? Data { get; set; }



        public static Result Success()
        {
            return new Result(true, ResultsCodeEnum.Success, Array.Empty<string>(), "", null);
        }

        public static Result Success(string message = "", object? data = null)
        {
            return new Result(true, ResultsCodeEnum.Success, Array.Empty<string>(), message, data);
        }

        public static Result Failure(IEnumerable<string> errors, string message = "", ResultsCodeEnum code = ResultsCodeEnum.Failure, object? data = null)
        {
            return new Result(false, code, errors, message, data);
        }




    }
}
