using ReactiveUI;

namespace FanShrine.Common
{
    internal class Artist : ReactiveObject, IArtist
    {
        public string Name { get; set; }
    }
}
