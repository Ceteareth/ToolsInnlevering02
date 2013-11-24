using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Innlevering02.ViewModel
{
    public class ListViewModel : ViewModelBase
    {
        #region Properties

        // A collection we bind to a listbox to display all unnamed entities
        public ObservableCollection<BaseEntity> UnnamedEntityCollection
        {
            get; private set;
        }

        // Index to sync changes in selection in the list with the displayed properties on the right.
        private int _unnamedEntityIndex;
        public int UnnamedEntityIndex
        {
            get { return _unnamedEntityIndex; }
            set
            {
                _unnamedEntityIndex = value;
                // If the value is valid, send a message to the property viewmodel to change the displayed values.
                if(value >= 0 && value < UnnamedEntityCollection.Count)
                    Messenger.Default.Send<BaseEntity, PropertyViewModel>(UnnamedEntityCollection.ElementAt(value));
            }
        }

        // Same as the unnamed collection, just for named entities/bosses
        public ObservableCollection<BaseEntity> NamedEntityCollection
        {
            get;
            private set;
        }

        // Same as over.
        private int _namedEntityIndex;
        public int NamedEntityIndex
        {
            get { return _namedEntityIndex; }
            set
            {
                _namedEntityIndex = value;
                if (value >= 0 && value < NamedEntityCollection.Count)
                Messenger.Default.Send<BaseEntity, PropertyViewModel>(NamedEntityCollection.ElementAt(value));
            }
        }
        #endregion

        #region Commands
        // Command binding for the save function on the menu
        public ICommand SaveCommand
        {
            get;
            internal set;
        }

        // Command binding for the load function on the menu
        public ICommand LoadCommand
        {
            get;
            internal set;
        }

        // Command binding for the load function on the menu
        public ICommand CloseCommand
        {
            get;
            internal set;
        }

        #endregion

        // Creates some default lists for editing stright off the bat, and sets the index to display the first in the list
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

        // Creates all the commands used in the menu
        private void CreateCommands()
        {
            SaveCommand = new RelayCommand(SaveExecute);
            LoadCommand = new RelayCommand(LoadExecute);
            CloseCommand = new RelayCommand(CloseExecute);
        }

        // Displays a file dialog and then saves a JSON serialized version of the collections at that place
        public void SaveExecute()
        {
            string unnamedEntities = JsonConvert.SerializeObject(UnnamedEntityCollection, Formatting.Indented);
            string namedEntitites = JsonConvert.SerializeObject(NamedEntityCollection, Formatting.Indented);
            //add a special character between the strings for easy separation later
            string serializedData = string.Concat(unnamedEntities,"£", namedEntitites);

            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog
            {
                FileName = "",
                DefaultExt = ".json",
                Filter = "Serialized data (.json)|*.json"
            };

            bool? result = dlg.ShowDialog();
            if(result == true)
                System.IO.File.WriteAllText(dlg.FileName, serializedData);
        }

        // Tries to deserialize and populate the lists with information from a previously saved JSON file
        public void LoadExecute()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                FileName = "",
                DefaultExt = ".json",
                Filter = "JSON file (.json)|*.json"
            };

            bool? result = dlg.ShowDialog();

            // If the user doesn't click ok, don't do anything
            if (result != true) return;

            // Gets all the information from the JSON file, splits it up into two pieces, one for unnamed entities and one for named
            String serializedData = System.IO.File.ReadAllText(dlg.FileName);
            String[] substring = Regex.Split(serializedData, "£");

            // Deserializes the unnamed list, clears the previously loaded list, and then populates the list with the new information
            ObservableCollection<BaseEntity> temp = JsonConvert.DeserializeObject<ObservableCollection<BaseEntity>>(substring[0]);
            UnnamedEntityCollection.Clear();

            foreach (BaseEntity b in temp)
            {
                UnnamedEntityCollection.Add(b);
            }

            // Clears the temporary list and deserializes the unnamed entities and puts that into the correct list.
            temp.Clear();
            temp = JsonConvert.DeserializeObject<ObservableCollection<BaseEntity>>(substring[1]);
            NamedEntityCollection.Clear();

            foreach (BaseEntity b in temp)
            {
                NamedEntityCollection.Add(b);
            }
        }

        // Simply closes the program
        public void CloseExecute()
        {
            Environment.Exit(0);
        }
    }
}