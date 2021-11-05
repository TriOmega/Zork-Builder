using System.ComponentModel;

namespace Zork
{
    public class Neighbor : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Directions Direction { get; set; }
        public string Name { get; set; }
    }
}
