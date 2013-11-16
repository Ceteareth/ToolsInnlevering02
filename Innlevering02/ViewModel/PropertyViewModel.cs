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

namespace Innlevering02.ViewModel
{
    public class PropertyViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;  

        private const string SelectedEntityHealthPropertyName = "SelectedEntityHealth";
        public int SelectedEntityHealth
        {
            get
            {
                return _currentlySelectedBaseEntity.Health;
            }

            set
            {
                if (_currentlySelectedBaseEntity.Health != value)
                {
                    Console.WriteLine("Changed health from " + _currentlySelectedBaseEntity.Health + " to " + value);
                    _currentlySelectedBaseEntity.Health = value;
                    RaisePropertyChanged(SelectedEntityHealthPropertyName);
                }
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
                if (_currentlySelectedBaseEntity.Damage != value)
                {
                    _currentlySelectedBaseEntity.Damage = value;
                    RaisePropertyChanged(SelectedEntityDamagePropertyName);
                }
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
                if (!_currentlySelectedBaseEntity.MovementSpeed.Equals(value))
                {
                    _currentlySelectedBaseEntity.MovementSpeed = value;
                    RaisePropertyChanged(SelectedEntityMovementSpeedPropertyName);
                }
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
                if (!_currentlySelectedBaseEntity.Invincible != value)
                {
                    _currentlySelectedBaseEntity.Invincible = value;
                    RaisePropertyChanged(SelectedEntityIsInvinciblePropertyName);
                }
            }
        }

        private BaseEntity _currentlySelectedBaseEntity;
        private Buzzer _buzzer;
        private KamikazeBuzzer _kamikazeBuzzer;
        private Mech _mech;
        private Player _player;
        private Spider _spider;

        public PropertyViewModel()
        {
            Messenger.Default.Register<BaseEntity>(this, OnReceivedEntity);
            _currentlySelectedBaseEntity = new BaseEntity();
            _buzzer = new Buzzer();
            _kamikazeBuzzer = new KamikazeBuzzer();
            _mech = new Mech();
            _player = new Player();
            _spider = new Spider();
        }

        private void OnReceivedEntity(BaseEntity obj)
        {
            SetCurrentEntity(obj);
        }

        private void SetCurrentEntity(BaseEntity obj)
        {
            if (_currentlySelectedBaseEntity.Name == _buzzer.Name)
            {
                _buzzer.Name = _currentlySelectedBaseEntity.Name;
                _buzzer.Health = _currentlySelectedBaseEntity.Health;
                _buzzer.Damage = _currentlySelectedBaseEntity.Damage;
                _buzzer.MovementSpeed = _currentlySelectedBaseEntity.MovementSpeed;
                _buzzer.Invincible = _currentlySelectedBaseEntity.Invincible;
            }
            else if (_currentlySelectedBaseEntity.Name == _kamikazeBuzzer.Name)
            {
                _kamikazeBuzzer.Name = _currentlySelectedBaseEntity.Name;
                _kamikazeBuzzer.Health = _currentlySelectedBaseEntity.Health;
                _kamikazeBuzzer.Damage = _currentlySelectedBaseEntity.Damage;
                _kamikazeBuzzer.MovementSpeed = _currentlySelectedBaseEntity.MovementSpeed;
                _kamikazeBuzzer.Invincible = _currentlySelectedBaseEntity.Invincible;
            }
            else if (_currentlySelectedBaseEntity.Name == _mech.Name)
            {
                _mech.Name = _currentlySelectedBaseEntity.Name;
                _mech.Health = _currentlySelectedBaseEntity.Health;
                _mech.Damage = _currentlySelectedBaseEntity.Damage;
                _mech.MovementSpeed = _currentlySelectedBaseEntity.MovementSpeed;
                _mech.Invincible = _currentlySelectedBaseEntity.Invincible;
            }
            else if (_currentlySelectedBaseEntity.Name == _spider.Name)
            {
                _spider.Name = _currentlySelectedBaseEntity.Name;
                _spider.Health = _currentlySelectedBaseEntity.Health;
                _spider.Damage = _currentlySelectedBaseEntity.Damage;
                _spider.MovementSpeed = _currentlySelectedBaseEntity.MovementSpeed;
                _spider.Invincible = _currentlySelectedBaseEntity.Invincible;
            }

            SelectedEntityHealth = obj.Health;
            SelectedEntityDamage = obj.Damage;
            SelectedEntityMovementSpeed = obj.MovementSpeed;
            SelectedEntityIsInvincible = obj.Invincible;

            _currentlySelectedBaseEntity = obj;

            Console.WriteLine(_currentlySelectedBaseEntity.Health);
        }
    }
}
