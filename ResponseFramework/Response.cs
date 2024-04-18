﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ResponseFramework
{
    public class Response<TResult> : IResponse<TResult>
    {
        public Response(TResult result)
        {
            Result = result;
            if(result != null)
            {
                IsSuccessful = true;
                Message = "Successful";
                ErrorMessage=string.Empty;
                HttpStatusCode = HttpStatusCode.OK;
            }
            else
            {
                IsSuccessful = false;
                Message = string.Empty;
                ErrorMessage = "Error";
                HttpStatusCode = HttpStatusCode.Ambiguous;
            }
        }

        public Response(string errorMessage)
        {
            IsSuccessful = false;
            Message = string.Empty; 
            ErrorMessage = errorMessage;
            Result = default;
            HttpStatusCode = HttpStatusCode.Ambiguous; 
        }

        public Response(bool isSuccessful, string? message, string? errorMessage, TResult? result, HttpStatusCode httpStatusCode)
        {
            IsSuccessful = isSuccessful;
            Message = message;
            ErrorMessage = errorMessage;
            Result = result;
            HttpStatusCode = httpStatusCode;
        }

        public bool IsSuccessful { get; set ; }
        public string? Message { get; set; }
        public string? ErrorMessage { get; set ; }
        public TResult? Result { get; set ; }
        public HttpStatusCode HttpStatusCode { get ; set ; }
    }
}
