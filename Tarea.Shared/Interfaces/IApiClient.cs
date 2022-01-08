using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tarea.Shared.ApiModels;

namespace Tarea.Shared.Interfaces
{
    public interface IApiClient
    {
        Task<ICollection<Region>> GetRegiones();
    }
}
