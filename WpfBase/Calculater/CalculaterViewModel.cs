using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfBase;

namespace CalculaterApplication
{
    class CalculaterViewModel:ViewModelBase
    {
        private Calculater _model=new Calculater();
        public string NumberText
        {
            get { return _model.Number; }
        }
        public string OperatorText
        {
            get { return _model.Operator; }
        }
        public ICommand AddNumberComand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.AddNumber(int.Parse(param.ToString()));
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand AddCommand
        {
            get { return new SimpleCommand(param=>
            {
                _model.Add();
                OnPropertyChanged("NumberText");
                OnPropertyChanged("OperatorText");
            }); }
        }
        public ICommand SubstructCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Substract();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand MultipleCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Multiple();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand DivideCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Divide();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
        public ICommand EnterCommand
        {
            get
            {
                return new SimpleCommand(param =>
                {
                    _model.Enter();
                    OnPropertyChanged("NumberText");
                    OnPropertyChanged("OperatorText");
                });
            }
        }
    }
}
