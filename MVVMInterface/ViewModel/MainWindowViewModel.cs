using MVVMInterface.Interface;
using MVVMInterface.Model;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace MVVMInterface.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        public ICalculater calculater;

        public int ItemA { get; set; }

        public int ItemB { get; set; }

        private int? _result;

        public int? Result { get => _result; set => SetProperty(ref _result, value); }

        public DelegateCommand AddCommand { get; }

        public DelegateCommand SubCommand { get; }

        public DelegateCommand MulCommand { get; }

        public DelegateCommand DivCommand { get; }

        public DelegateCommand CalculateCommand { get; }

        public DelegateCommand GetValueCommand { get; }

        public DelegateCommand ClearCommand { get; }

        public MainWindowViewModel()
        {
            AddCommand = new DelegateCommand(() => InjectionCalculater(new Adder()));
            SubCommand = new DelegateCommand(() => InjectionCalculater(new Subtracter()));
            MulCommand = new DelegateCommand(() => InjectionCalculater(new Multiplyer()));
            DivCommand = new DelegateCommand(() => InjectionCalculater(new Divider()));
            CalculateCommand = new DelegateCommand(() => Result = calculater?.Calculate(ItemA, ItemB));
            GetValueCommand = new DelegateCommand(() => Result = calculater?.GetStorage);
            ClearCommand = new DelegateCommand(() =>
            {
                if (calculater == null)
                {
                    MessageBox.Show("calculater is null");
                    return;
                }
                calculater.Clear();
            });
        }

        public void InjectionCalculater(ICalculater ic) => this.calculater = ic;
    }
}
