using Prism.Commands;
using Prism.Mvvm;
using PrismApplicationSample.Model;
using System.Windows.Input;

namespace PrismApplicationSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _status;
        public string InputStatus
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        public DelegateCommand Update { get; }
        private void UpdateExecute()
        {
            _modelRepository.SaveStatus(InputStatus);
            RaisePropertyChanged(nameof(CurrentStatus));
        }

        public string CurrentStatus
        {
            get { return _modelRepository.GetStatus(); }
        }

        IModelRepository _modelRepository;
        public MainWindowViewModel(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
            Update = new DelegateCommand(UpdateExecute);
        }
    }
}
