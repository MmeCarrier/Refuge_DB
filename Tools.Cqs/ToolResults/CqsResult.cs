using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Cqs.ToolResults
{
    public class CqsResult : ICqsResult
    {
        public static ICqsResult Success()
        {
            return new CqsResult(true);
        }
        public static ICqsResult Failure(string errorMessage)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(errorMessage);
            return new CqsResult(false, errorMessage);
        }

        public bool IsSuccess { get; }
        public bool IsFailure { get { return !IsSuccess; } }
        public string? ErrorMessage { get; }
        private CqsResult(bool isSuccess, string? errorMessage = null)
        { 
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
        }
    }

    public class CqsResult<TResult> : ICqsResult<TResult>
    {
        public static CqsResult<TResult> Success(TResult data)
        {
            return new CqsResult<TResult>(true, data);
        }

        public static ICqsResult<TResult> Failure(string errorMessage)
        { 
            ArgumentException.ThrowIfNullOrWhiteSpace(errorMessage);
            return new CqsResult<TResult>(false, errorMessage: errorMessage); 
        }
        public bool IsSuccess { get; }
        public bool IsFailure
        {   
            get
            {
                return !IsSuccess; 
            } 
        }
        public string? ErrorMessage { get; }
        public TResult Data { get; }
        private CqsResult(bool isSuccess, TResult data = default!, string? errorMessage = null)
        {
            IsSuccess = isSuccess;
            Data = data;
            ErrorMessage = errorMessage;
        }
    }
}
