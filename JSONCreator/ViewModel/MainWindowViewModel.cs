using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JSONCreator.Annotations;
using JSONCreator.BusinessLogic;

namespace JSONCreator.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
      //  private readonly JSONObjectCreator _jsonCreator = new JSONObjectCreator();

        public string NameBox1 { get; set; }

        public string ValueBox1 { get; set; }

        public string NameBox2 { get; set; }

        public string ValueBox2 { get; set; }

        public string NameBox3 { get; set; }

        public string ValueBox3 { get; set; }

        private string _result;

        public string Result
        {
            get { return _result;}
            set
            {
                _result = value;
                OnPropertyChanged();
            } 
        }

        public RelayCommand SubmitCommand { get; private set; }

        public MainWindowViewModel()
        {
          SubmitCommand = new RelayCommand(OnSubmit);
        }

        private void OnSubmit()
        {
            var resultDictionary = new Dictionary<string, string>
            {
                {NameBox1, ValueBox1},
                {NameBox2, ValueBox2},
                {NameBox3, ValueBox3}
            };

            var result = JSONObjectCreator.CreateJsonObject(resultDictionary);
           Result = result;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
