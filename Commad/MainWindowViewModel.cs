using Commad.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commad
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _studentCode ;
        private string _studenName ;
        private ObservableCollection<Student> _students;
        private Student _selectedStuden;
        public string StudentCode
        {

            get => _studentCode;
            set
            {
                _studentCode = value;
                OnPropertyChanged(nameof(StudentCode));
            }


        }
        public string StudenName
        {
            get => _studenName; 
            set
            {
                _studenName = value;
                OnPropertyChanged(nameof(StudenName));
            }
        }
        public ObservableCollection<Student> Students
        {
            get => _students;
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }
        public Student SelectedStuden
        {
            get => (Student)_selectedStuden;
            set
            {
                _selectedStuden = value;
                OnPropertyChanged(nameof(SelectedStuden));
            }
        }
        public ICommand AddStudentCommand { get; set; }
        public ICommand DeleteStudentCommand { get; set; }
        public MainWindowViewModel()
        {
            StudentCode = new string("");
            StudenName = new string("");
            Students = new ObservableCollection<Student>();
            AddStudentCommand = new AddStudentCommand(this);
        }

    }
}
