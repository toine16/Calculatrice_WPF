using compteur_wpf.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace compteur_wpf 
{
    class MainWindowsView : INotifyPropertyChanged
    {
        private int _Value;
        private ObservableCollection<IntValue> _maList;
        private ICommand _Incr;
        private ICommand _Dcr;
        private ICommand _Add;

        public event PropertyChangedEventHandler PropertyChanged;


        public int Value
        {
            get
            {
                return _Value;
            }

            set
            {
                _Value = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            }
        }
        public ObservableCollection<IntValue> MaList
        {
            get
            {
                return _maList;
            }

            set
            {
                _maList = value;
            }
        }
        public ICommand Add
        {
            get
            {
                if(_Add == null)
                {
                    _Add = new RelayCommand(AddValue);
                }
                return _Add;
            }
        }

        public ICommand Incr
        {
            get
            {
                if(_Incr == null)
                {
                    return _Incr = new RelayCommand(Increment);
                }
                return _Incr;
            }
        }

        public ICommand Dcr
        {
            get
            {
                if(_Dcr == null)
                {
                    return _Dcr = new RelayCommand(Decrement);
                }
                return _Dcr;
            }
        }

        
        public MainWindowsView()
        {
            Value = 0;
            MaList = new ObservableCollection<IntValue>();
        }

        private void AddValue()
        {
            MaList.Add(new IntValue(Value));           

        }
        private void Increment()
        {
            if(Value < 9)
            {
                Value++;
            }
        }
        private void Decrement()
        {
            if(Value > 0)
            {
                Value--;
            }
        }

    }
}
