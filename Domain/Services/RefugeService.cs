using Domain.Commands;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolCommands;
using Tools.Cqs.ToolResults;

namespace Domain.Services
{
    public class RefugeService : IRefugeRepository
    {
        bool ICqsResult.IsSuccess => throw new NotImplementedException();

        bool IcqsResult<Benevole>.IsSuccess => throw new NotImplementedException();

        bool ICqsResult.IsFailure => throw new NotImplementedException();

        bool IcqsResult<Benevole>.IsFailure => throw new NotImplementedException();

        string ICqsResult.ErrorMessage => throw new NotImplementedException();

        string IcqsResult<Benevole>.ErrorMessage => throw new NotImplementedException();

        Benevole IcqsResult<Benevole>.Data => throw new NotImplementedException();

        ICqsResult ICommandHandler<AjoutBenevole>.Execute(AjoutBenevole command)
        {
            throw new NotImplementedException();
        }
    }
}
