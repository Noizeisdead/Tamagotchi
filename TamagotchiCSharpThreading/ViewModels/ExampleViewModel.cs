using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TamagotchiCSharpThreading.ViewModels
{
    class ExampleViewModel: INotifyPropertyChanged
    {
        private String _btnText = "Click me";

        private int count = 0;

        public String CounterBtn
        {
            get => _btnText; 
            set
            {
                _btnText = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand CounttestCommand { get; private set; }

        public ExampleViewModel() 
        {
            CounttestCommand = new Command(() =>
            {
                count++;

                if (count == 1)
                    CounterBtn = $"Clicked {count} time";
                else
                    CounterBtn = $"Clicked {count} times";
            });
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
