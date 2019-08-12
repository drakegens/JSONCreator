using System;
using JSONCreator.BusinessLogic;

namespace JSONCreator.ViewModel
{
    class MainWindowViewModel : ObservableObject
    {
        private JSONObjectCreator _jsonCreator = new JSONObjectCreator();


        private string name1;

        public string Name1
        {
            get => this.name1;
            set
            {
                name1 = value;
               RaisePropertyChangedEvent("propertyName");
            }
        }
    }
}
