using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetPcl.Models
{
    public class Result<T>
    {
        public Result(bool isOk, string message, T data ){
            Ok=isOk;
            Message=message;
            Data=data;
        }
        public Result(T data, string message="Success"){
            Ok=true;
            Message=message;
            Data=data;
        }
        public bool Ok { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
