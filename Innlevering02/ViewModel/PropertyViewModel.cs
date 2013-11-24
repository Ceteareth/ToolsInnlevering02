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
        private const string CurrentEntityPropertiesPropertyName = "CurrentEntityProperties";
        public ObservableCollection<BaseProperty> CurrentEntityProperties
        {
            get
            {
                return _currentEntityProperties;
            }
            set
            {
                if (_currentEntityProperties.Equals(value)) return;
                _currentEntityProperties = value;
                RaisePropertyChanged(CurrentEntityPropertiesPropertyName);
            }
        }

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

        public string Value { get; set; }

        private ObservableCollection<BaseProperty> _currentEntityProperties;
        private string _currentInfoString;

        public PropertyViewModel()
        {
            Messenger.Default.Register<BaseEntity>(this, OnReceivedEntity);

            _currentEntityProperties = new ObservableCollection<BaseProperty>();
            _currentInfoString = "No entity selected. Click one an entity on the list to the left to start your editing.";
        }

        private void OnReceivedEntity<T>(T obj)
        {
            CurrentInfoString = "Entity selected! Edit the stats of your choice and press Save to export the information";
            BaseEntity baseEntity = obj as BaseEntity;
            if (baseEntity != null) CurrentEntityProperties = baseEntity.PropertyCollection;
        }
    }
}
