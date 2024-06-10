using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NotifyPropertyChanged_Practice
{
    public class MainWindowVM_Practive : INotifyPropertyChanged
    {
        #region Private
        private string _day;
        private string _month;
        private string _year;
        private string _h;
        private string _check1, _check2, _check3;
        #endregion
        #region Properties
        public string Day
        {
            get { return _day; }
            set
            {
                _day = value;
                OnPropertyChanged(nameof(Day));
                OnPropertyChanged(nameof(H));
                OnPropertyChanged(nameof(Check_1));
            }
        }
        public string Month
        {
            get { return _month; }
            set
            {
                _month = value;
                OnPropertyChanged(nameof(Month));
                OnPropertyChanged(nameof(H));
                OnPropertyChanged(nameof(Check_2));

            }
        }
        public string Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged(nameof(Year));
                OnPropertyChanged(nameof(H));
                OnPropertyChanged(nameof(Check_3));

            }
        }
        public string H
        {
            get { return _h = _day + "/" + _month + "/" + _year; }
            set
            {
                _h = value;
                OnPropertyChanged(nameof(H));
            }
        }

        public string Check_1
        {
            get
            {
                if (IsNumber(_day) == false)
                {
                    _check1 = " Sai dinh dang";
                }
                else _check1 = "";
                return _check1;
            }
            set
            {
                _check1 = value;
                OnPropertyChanged(nameof(Check_1));
            }

        }
        public string Check_2
        {
            get
            {
                if (IsNumber(_month) == false)
                {
                    _check2 = " Sai dinh dang";
                }
                else _check2 = "";
                return _check2;
            }
            set
            {
                _check2 = value;
                OnPropertyChanged(nameof(Check_2));
            }

        }
        public string Check_3
        {
            get
            {
                if (IsNumber(_year) == false)
                {
                    _check3 = " Sai dinh dang";
                }
                else _check3 = "";
                return _check3;
            }
            set
            {
                _check3 = value;
                OnPropertyChanged(nameof(Check_3));
            }

        }
        private bool IsNumber(string number)
        {
            bool isNumber = int.TryParse(number, out int n);
            return isNumber;
        }

        #endregion
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
