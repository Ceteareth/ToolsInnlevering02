using System;
using System.Collections;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Innlevering02.Model.Custom_Models;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;
using Newtonsoft.Json;

namespace Innlevering02.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        #region Properties
        // This property contains all the relevant properties for the selected entity in the list in ListViewModel
        private const string CurrentEntityPropertiesPropertyName = "CurrentEntityProperties";
        public ObservableCollection<BaseProperty> CurrentEntityProperties
        {
            get
            {
                return _currentEntityProperties;
            }
            set
            {
                // When the property is changed, it signals the view
                if (_currentEntityProperties.Equals(value)) return;
                _currentEntityProperties = value;
                RaisePropertyChanged(CurrentEntityPropertiesPropertyName);
            }
        }

        // More or less the same as over, except that it displays helpful info for new users. 
        // Only two tips added so far.
        private const string CurrentInfoStringPropertyName = "CurrentInfoString";
        public string CurrentInfoString
        {
            get
            {
                return _currentInfoString;
            }
            set
            {
                if (_currentInfoString == value) return;
                _currentInfoString = value;
                RaisePropertyChanged(CurrentInfoStringPropertyName);
            }
        }
        #endregion

        // The current info string displayed, as well as the current collection of properties that should be displayed

        private ObservableCollection<BaseProperty> _currentEntityProperties;
        private string _currentInfoString;

        // Registers with the messaging system that it can receive messages of baseentity type, and routes any messages to the OnReceivedEntity method.
        // Sets som default values as well.
        public PropertyViewModel()
        {
            Messenger.Default.Register<BaseEntity>(this, OnReceivedEntity);

            _currentEntityProperties = new ObservableCollection<BaseProperty>();
            _currentInfoString = "No entity selected. Click one an entity on the list to the left to start your editing.";
        }

        // Changes the collection of properties that should be displayed based on which entity is sent through from the other viewmodel.
        // Also changes the tips.
        private void OnReceivedEntity<T>(T obj)
        {
            CurrentInfoString = "Entity selected! Edit the stats of your choice and press Save to export the information";
            BaseEntity baseEntity = obj as BaseEntity;
            if (baseEntity != null) CurrentEntityProperties = baseEntity.PropertyCollection;
        }
    }
}
