using Domain.Commands;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;

namespace Domain.Services
{
    public class RefugeService : IRefugeRepository
    {
        private readonly DbConnection _dbConnection;

        public RefugeService(DbConnection dbConnection)
        { 
            _dbConnection = dbConnection;
            if (_dbConnection.State is not System.Data.ConnectionState.Open)
            {
                _dbConnection.Open();
            }
        }
        bool ICqsResult.IsSuccess => throw new NotImplementedException();

        bool IcqsResult<Benevole>.IsSuccess => throw new NotImplementedException();

        bool ICqsResult.IsFailure => throw new NotImplementedException();

        bool IcqsResult<Benevole>.IsFailure => throw new NotImplementedException();

        string ICqsResult.ErrorMessage => throw new NotImplementedException();

        string IcqsResult<Benevole>.ErrorMessage => throw new NotImplementedException();

        Benevole IcqsResult<Benevole>.Data => throw new NotImplementedException();

        ICqsResult ICommandHandler<AjoutBenevole>.Execute(AjoutBenevole command)
        {
            try
            {
                _dbConnection.ExecuteNonQuery
            }
            throw new NotImplementedException();
        }
    }
}
