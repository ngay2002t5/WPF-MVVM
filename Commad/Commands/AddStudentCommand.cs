using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commad.Commands
{
    public class AddStudentCommand : ICommand
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        public AddStudentCommand(MainWindowViewModel mainWindowViewModel)
        { _mainWindowViewModel = mainWindowViewModel; }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Student student = new Student()
            {
                StudentCode = _mainWindowViewModel.StudentCode,
                StudentName = _mainWindowViewModel.StudenName
            };
            _mainWindowViewModel.Students.Add(student);
        }
    }
}
