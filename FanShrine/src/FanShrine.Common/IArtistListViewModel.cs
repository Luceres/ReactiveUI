using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;

namespace FanShrine.Common
{
    public interface IArtistListViewModel
    {
        ReactiveList<IArtist> Artists { get; }

        ReactiveCommand<Unit, Unit> LoadListCommand { get; }
    }
}
