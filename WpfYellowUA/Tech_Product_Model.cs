using System.Runtime.CompilerServices;
using System.ComponentModel;
namespace WpfYellowUA
{
    public class Tech_Product_Model : INotifyPropertyChanged
    {

        private string _name;
        private int _price;
        private int _img;

        public string Name
        {
            get { return _name; }
            set { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Price
        {
            get { return _price; }
            set { 
                _price = value;
                OnPropertyChanged("Price");
            }
        }


        public Tech_Product_Model(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = " ")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
