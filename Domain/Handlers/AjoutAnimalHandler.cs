using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Tools.Cqs.ToolResults;
using RefugeManagerShared;
using RefugeManagerShared.SharedEntities;
using RefugeManagerShared.SharedDbContext;

namespace Domain.Handlers
{
    public class AjoutAnimalHandler
    {
        private readonly RefugeContext _context;

        public AjoutAnimalHandler(RefugeContext context)
        {
            _context = context;
        }
        public async Task<ICqsResult> Handle(AjoutAnimalCommand command)
        { var animal = new Animal
        }
    }
}
