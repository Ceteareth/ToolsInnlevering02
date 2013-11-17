using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Innlevering02.Model;
using Innlevering02.Model.Custom_Models;
using Innlevering02.Model.Custom_Models.Property_Classes;

namespace Innlevering02.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        /*private const string SelectedEntityHealthPropertyName = "SelectedEntityHealth";
        public int SelectedEntityHealth
        {
            get
            {
                return _currentlySelectedBaseEntity.Health;
            }

            set
            {
                if (_currentlySelectedBaseEntity.Health == value) return;
                _currentlySelectedBaseEntity.Health = value;
                RaisePropertyChanged(SelectedEntityHealthPropertyName);
            }
        }

        private const string SelectedEntityDamagePropertyName = "SelectedEntityDamage";
        public int SelectedEntityDamage
        {
            get
            {
                return _currentlySelectedBaseEntity.Damage;
            }

            set
            {
                if (_currentlySelectedBaseEntity.Damage == value) return;
                _currentlySelectedBaseEntity.Damage = value;
                RaisePropertyChanged(SelectedEntityDamagePropertyName);
            }
        }

        private const string SelectedEntityMovementSpeedPropertyName = "SelectedEntityMovementSpeed";
        public float SelectedEntityMovementSpeed
        {
            get
            {
                return _currentlySelectedBaseEntity.MovementSpeed;
            }

            set
            {
                if (_currentlySelectedBaseEntity.MovementSpeed.Equals(value)) return;
                _currentlySelectedBaseEntity.MovementSpeed = value;
                RaisePropertyChanged(SelectedEntityMovementSpeedPropertyName);
            }
        }

        private const string SelectedEntityIsInvinciblePropertyName = "SelectedEntityIsInvincible";
        public bool SelectedEntityIsInvincible
        {
            get
            {
                return _currentlySelectedBaseEntity.Invincible;
            }

            set
            {
                if (!_currentlySelectedBaseEntity.Invincible == value) return;
                _currentlySelectedBaseEntity.Invincible = value;
                RaisePropertyChanged(SelectedEntityIsInvinciblePropertyName);
            }
        }*/

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

        private ObservableCollection<BaseProperty> _currentEntityProperties; 
        private BaseEntity _currentlySelectedBaseEntity;
        private Buzzer _buzzer;
        private KamikazeBuzzer _kamikazeBuzzer;
        private Mech _mech;
        private Player _player;
        private Spider _spider;

        public string Value { get; set; }
        public Type TheType { get; set; }

        public PropertyViewModel()
        {
            Messenger.Default.Register<BaseEntity>(this, OnReceivedEntity);
            _currentEntityProperties = new ObservableCollection<BaseProperty>();
            _currentlySelectedBaseEntity = new BaseEntity();
            _buzzer = new Buzzer();
            _kamikazeBuzzer = new KamikazeBuzzer();
            _mech = new Mech();
            _player = new Player();
            _spider = new Spider();
            _currentEntityProperties = _spider.PropertyCollection;
        }

        private void OnReceivedEntity<T>(T obj)
        {
            if (obj.GetType() == _buzzer.GetType())
            {
                Buzzer buzzer = obj as Buzzer;
                if (buzzer != null)
                {
                    CurrentEntityProperties = buzzer.PropertyCollection;
                }
            }
            else if (obj.GetType() == _kamikazeBuzzer.GetType())
            {
                KamikazeBuzzer kamikazeBuzzer = obj as KamikazeBuzzer;
                if (kamikazeBuzzer != null)
                {
                    CurrentEntityProperties = kamikazeBuzzer.PropertyCollection;
                }
            }
            else if (obj.GetType() == _mech.GetType())
            {
                Mech mech = obj as Mech;
                if (mech != null)
                {
                    CurrentEntityProperties = mech.PropertyCollection;
                }
            }
            else if (obj.GetType() == _spider.GetType())
            {
                Spider spider = obj as Spider;
                if (spider != null)
                {
                    CurrentEntityProperties = spider.PropertyCollection;
                }
            }
        }
    }
}
