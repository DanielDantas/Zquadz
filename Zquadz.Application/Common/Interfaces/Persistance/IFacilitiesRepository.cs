using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zquadz.Domain.Entities;

namespace Zquadz.Application.Common.Interfaces.Persistance
{
    public interface IFacilitiesRepository
    {
        Task<Facility?> GetById(Guid id);
        Task<Facility> Create(Facility facility);
    }
}
