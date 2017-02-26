using System.Collections.Generic;
using System.Threading.Tasks;

namespace FanShrine.Common.Data
{
    internal interface IDataService
    {
        Task<List<IArtist>> LoadAllArtistsAsync(int slowness);
    }
}