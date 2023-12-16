using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTI_Generative_AI_Academic_Yearly_Report.Model;

namespace DTI_Generative_AI_Academic_Yearly_Report.ViewModels
{
    public class DocumentViewModel : INotifyPropertyChanged
    {
        private DocumentModel _document;

        public string Title
        {
            get => _document.Title;
            set
            {
                _document.Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string Description { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
