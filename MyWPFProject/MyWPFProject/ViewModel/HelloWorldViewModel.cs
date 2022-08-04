using MyWPFProject.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyWPFProject.ViewModel
{
    public class HelloWorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name { get; set; } = "Bhavana";

        private string helloString = "Bhavana";

        public string HelloString
        {
            get => helloString;
            set
            {
                helloString = value;
                OnPropertyChanged();
            }
        }

        public HelloWorldViewModel()
        {
            var HW = new HelloWorldModel();
            helloString = HW.ImportantInfo;
        }

        /// <summary>
        /// Raises OnPropertychangedEvent when property changes
        /// </summary>
        /// <param name="name">String representing the property name</param>
        protected void OnPropertyChanged([CallerMemberName] string name = "Bhavana")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
