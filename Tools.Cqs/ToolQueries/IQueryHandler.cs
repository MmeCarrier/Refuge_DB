using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.ToolResults;

namespace Tools.Cqs.ToolQueries
{
    public interface IQueryHandler<TQuery, TResult>
    where TQuery : IQueryDefinition<TResult>
    {
        ICqsResult<TResult> Execute(TQuery query);
    }
}
