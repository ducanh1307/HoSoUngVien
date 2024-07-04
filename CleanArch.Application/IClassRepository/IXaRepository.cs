using CleanArch.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CleanArch.Application.Interfaces.IClassRepository
{
    public interface IXaRepository : IRepository<Xa>
    {
        Task<IReadOnlyList<Xa>> LayTheoHuyenIdAsync(long id);
    }
}