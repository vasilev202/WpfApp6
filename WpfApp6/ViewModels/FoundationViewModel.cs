using System;
using System.ComponentModel;
using System.Windows.Input;
using WpfApp6.Models;

namespace WpfApp6.ViewModels
{
    public class FoundationViewModel : INotifyPropertyChanged
    {
        private FoundationModel _model;

        public FoundationViewModel()
        {
            _model = new FoundationModel();
        }

        public double Length
        {
            get => _model.Length;
            set { _model.Length = value; OnPropertyChanged(nameof(Length)); }
        }

        public double Width
        {
            get => _model.Width;
            set { _model.Width = value; OnPropertyChanged(nameof(Width)); }
        }

        public double Height
        {
            get => _model.Height;
            set { _model.Height = value; OnPropertyChanged(nameof(Height)); }
        }

        public double ConcretePrice
        {
            get => _model.ConcretePrice;
            set { _model.ConcretePrice = value; OnPropertyChanged(nameof(ConcretePrice)); }
        }

        public double ReinforcementPrice
        {
            get => _model.ReinforcementPrice;
            set { _model.ReinforcementPrice = value; OnPropertyChanged(nameof(ReinforcementPrice)); }
        }

        public double SandPrice
        {
            get => _model.SandPrice;
            set { _model.SandPrice = value; OnPropertyChanged(nameof(SandPrice)); }
        }

        public double GravelPrice
        {
            get => _model.GravelPrice;
            set { _model.GravelPrice = value; OnPropertyChanged(nameof(GravelPrice)); }
        }

        public double Volume => _model.Volume;
        public double Mass => _model.Mass;
        public double ConcreteCost => _model.ConcreteCost;
        public double ReinforcementCost => _model.ReinforcementCost;
        public double SandCost => _model.SandCost;
        public double GravelCost => _model.GravelCost;
        public double TotalCost => _model.TotalCost;

        public ICommand CalculateCommand => new RelayCommand(Calculate);

        private void Calculate()
        {
            // Trigger property change notifications for calculated values
            OnPropertyChanged(nameof(Volume));
            OnPropertyChanged(nameof(Mass));
            OnPropertyChanged(nameof(ConcreteCost));
            OnPropertyChanged(nameof(ReinforcementCost));
            OnPropertyChanged(nameof(SandCost));
            OnPropertyChanged(nameof(GravelCost));
            OnPropertyChanged(nameof(TotalCost));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}