using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmExample.ViewModels
{
    internal class ViewModelMainWindow : Base.ModelView
    {
        public ViewModelMainWindow()
        {
            currentModel = Models.Mocks.GetMock();
            SyncronizeWithModel();
        }

        #region Fields
        ObservableCollection<string> groupList;
        string nameText;
        #endregion Fields

        #region Properties
        public Models.StudentModel currentModel { get; set; }
        public ObservableCollection<string> GroupList
        {
            get => groupList;
            set => Set(ref groupList, value);
        }
        public string NameText
        {
            get => nameText;
            set => Set(ref nameText, value);
        }
        #endregion Properties

        #region Events

        #endregion Events

        #region Constructors
        #endregion Constructors

        #region Methods
        void SyncronizeWithModel()
        {
            GroupList = new ObservableCollection<string>(currentModel.Group);
            NameText = currentModel.Name;
            
        }
        void RewriteNameText()
        {
            NameText = "TEST";
            //if (String.Equals(NameText, "Вася"))
            //{
            //    NameText = "Петя";
            //}
        }
        #region Privates

        #endregion Privates	

        #region Public

        #endregion Public

        #endregion Methods
        #region Commands
        public ICommand RewriteNameTextComm
        {
            get
            {
                return new RelayCommand(() => RewriteNameText(), true);
            }
        }
        #endregion Commands
    }
}
