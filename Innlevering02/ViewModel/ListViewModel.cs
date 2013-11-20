using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mime;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Innlevering02.Model.Custom_Models;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models;
using Newtonsoft.Json;

namespace Innlevering02.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ListViewModel : ViewModelBase
    {
        #region Properties
        public ObservableCollection<BaseEntity> UnnamedEntityCollection
        {
            get; private set;
        }

        private int _unnamedEntityIndex;
        public int UnnamedEntityIndex
        {
            get { return _unnamedEntityIndex; }
            set
            {
                _unnamedEntityIndex = value;
                Messenger.Default.Send<BaseEntity, PropertyViewModel>(UnnamedEntityCollection.ElementAt(value));
            }
        }

        public ObservableCollection<BaseEntity> NamedEntityCollection
        {
            get;
            private set;
        }

        private int _namedEntityIndex;
        public int NamedEntityIndex
        {
            get { return _namedEntityIndex; }
            set
            {
                _namedEntityIndex = value;
                Messenger.Default.Send<BaseEntity, PropertyViewModel>(NamedEntityCollection.ElementAt(value));
            }
        }
        #endregion

        #region Commands
        public ICommand SaveCommand
        {
            get;
            internal set;
        }

        public ICommand LoadCommand
        {
            get;
            internal set;
        }

        public ICommand CloseCommand
        {
            get;
            internal set;
        }
        #endregion

        public ListViewModel()
        {
            UnnamedEntityCollection = new ObservableCollection<BaseEntity>
            {
                new Buzzer(),
                new KamikazeBuzzer(),
                new Mech(),
                new Spider()
            };
            UnnamedEntityIndex = 0;

            NamedEntityCollection = new ObservableCollection<BaseEntity>
            {
                new Player(),
                new ConfusedMech()
            };
            NamedEntityIndex = 0;

            CreateCommands();
        }

        private void CreateCommands()
        {
            SaveCommand = new RelayCommand(SaveExecute);
            LoadCommand = new RelayCommand(LoadExecute);
            CloseCommand = new RelayCommand(CloseExecute);
        }

        public void SaveExecute()
        {
            string unnamedEntities = JsonConvert.SerializeObject(UnnamedEntityCollection, Formatting.Indented);
            string namedEntitites = JsonConvert.SerializeObject(NamedEntityCollection, Formatting.Indented);
            string serializedData = string.Concat(unnamedEntities, namedEntitites);
            System.IO.File.WriteAllText(@"C:\temp\Temp.json", serializedData);
        }

        public void LoadExecute()
        {
            
        }

        public void CloseExecute()
        {
            Environment.Exit(0);
        }
    }
}