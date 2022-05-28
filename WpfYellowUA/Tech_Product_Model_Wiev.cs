using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace WpfYellowUA
{
    class Tech_Product_Model_Wiev : INotifyPropertyChanged
    {
        public ObservableCollection<Tech_Product_Model> Tech_Products { get; set; }
        public Tech_Product_Model_Wiev()
        {
            Tech_Products = new ObservableCollection<Tech_Product_Model>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = " ")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
