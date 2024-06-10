using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyPropertuChanged
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        #region Privates
        private string _firstName;
        private string _lastName;
        private string _fullName;
        #endregion
        #region Propertes
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value; OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string FullName
        {
            get { return _fullName = _firstName + " " + _lastName; }
            set
            {
                _fullName = value; OnPropertyChanged(nameof(FullName));
            }
        }
        #endregion
        
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
