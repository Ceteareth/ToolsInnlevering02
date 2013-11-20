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
            if (obj.GetType() == typeof(Buzzer))
            {
                Buzzer buzzer = obj as Buzzer;
                if (buzzer != null)
                {
                    CurrentEntityProperties = buzzer.PropertyCollection;
                }
            }
            else if (obj.GetType() == typeof(KamikazeBuzzer))
            {
                KamikazeBuzzer kamikazeBuzzer = obj as KamikazeBuzzer;
                if (kamikazeBuzzer != null)
                {
                    CurrentEntityProperties = kamikazeBuzzer.PropertyCollection;
                }
            }
            else if (obj.GetType() == typeof(Mech))
            {
                Mech mech = obj as Mech;
                if (mech != null)
                {
                    CurrentEntityProperties = mech.PropertyCollection;
                }
            }
            else if (obj.GetType() == typeof(Spider))
            {
                Spider spider = obj as Spider;
                if (spider != null)
                {
                    CurrentEntityProperties = spider.PropertyCollection;
                }
            }
            else if (obj.GetType() == typeof(Player))
            {
                Player player = obj as Player;
                if (player != null)
                {
                    CurrentEntityProperties = player.PropertyCollection;
                }
            }
            else if (obj.GetType() == typeof(ConfusedMech))
            {
                ConfusedMech confusedMech = obj as ConfusedMech;
                if (confusedMech != null)
                {
                    CurrentEntityProperties = confusedMech.PropertyCollection;
                }
            }
        }
    }
}
