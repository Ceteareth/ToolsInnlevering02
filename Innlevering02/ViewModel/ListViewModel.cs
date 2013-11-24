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
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

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
                if(value >= 0 && value < UnnamedEntityCollection.Count)
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
                new BaseEntity("Buzzer", new BaseProperty("Health", 20), new BaseProperty("Damage", 20),  new BaseProperty("Movement speed", 20f),new BaseProperty("Invincible", false)),
                new BaseEntity("Mech", new BaseProperty("Health", 100), new BaseProperty("Damage", 50),  new BaseProperty("Movement speed", 5f),new BaseProperty("Invincible", false)),
                new BaseEntity("Spider", new BaseProperty("Health", 20), new BaseProperty("Damage", 20),  new BaseProperty("Movement speed", 20f),new BaseProperty("Invincible", false), new BaseProperty("Creepy", true)),
                new BaseEntity("Kamikaze Buzzer", new BaseProperty("Health", 5), new BaseProperty("Damage", 50),  new BaseProperty("Movement speed", 20f),new BaseProperty("Invincible", false)),
            };
            UnnamedEntityIndex = 0;

            NamedEntityCollection = new ObservableCollection<BaseEntity>
            {
                new BaseEntity("Player", new BaseProperty("Health", 500), new BaseProperty("Damage", 40),  new BaseProperty("Movement speed", 20f),new BaseProperty("Invincible", true)),
                new BaseEntity("Confused mech", new BaseProperty("Health", 110), new BaseProperty("Damage", 55),  new BaseProperty("Movement speed", 5f),new BaseProperty("Invincible", false))
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
            //add a special character between the strings for easy separation later
            string serializedData = string.Concat(unnamedEntities,"£", namedEntitites);
            System.IO.File.WriteAllText(@"C:\temp\Temp.json", serializedData);
        }

        public void LoadExecute()
        {
            String serializedData = System.IO.File.ReadAllText(@"C:\temp\Temp.json");
            String[] substring = Regex.Split(serializedData,"£");
            ObservableCollection<BaseEntity> temp = JsonConvert.DeserializeObject<ObservableCollection<BaseEntity>>(substring[0]);
            UnnamedEntityCollection.Clear();

            foreach (BaseEntity b in temp)
            {
                UnnamedEntityCollection.Add(b);
            }
        }

        public void CloseExecute()
        {
            Environment.Exit(0);
        }
    }
}