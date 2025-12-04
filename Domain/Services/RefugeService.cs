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
using Tools.Database;

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

        

        public ICqsResult Execute(AjoutBenevole command)
        {
            try
            {
                _dbConnection.ExecuteNonQuery("AjoutBenevole", true, command);
                    return CqsResult.Success();
            }
            catch(Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }

        public ICqsResult Execute(SupprimerBenevole command)
        {
            try
            {
                int rows = _dbConnection.ExecuteNonQuery("SupprimerBenevole", true, command);

                if (rows == 1)
                    return CqsResult.Success();

                return CqsResult.Failure("Benevole introuvable");
            }
            catch(Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }

        }
        public ICqsResult Execute(UpdateBenevole command)
        {
            try
            {
                int rows = _dbConnection.ExecuteNonQuery("UpdateBenevole", true, command);
                if (rows == 1)
                    return CqsResult.Success();
                return CqsResult.Failure("Benevole à supprimer introuvable");
            }
            catch(Exception ex)
            {
                return CqsResult.Failure(ex.Message);
            }
        }
    }
}
