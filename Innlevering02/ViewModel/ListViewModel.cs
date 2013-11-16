using System;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Innlevering02.Model;
using Innlevering02.Model.Custom_Models;

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

        public ObservableCollection<BaseEntity> EntityCollection
        {
            get; private set;
        }

        private int _entityIndex;
        public int EntityIndex
        {
            get { return _entityIndex; }
            set
            {
                _entityIndex = value;
                Messenger.Default.Send<BaseEntity, PropertyViewModel>(EntityCollection.ElementAt(value));
            }
        }

        private Buzzer _buzzer;
        private KamikazeBuzzer _kamikazeBuzzer;
        private Mech _mech;
        private Player _player;
        private Spider _spider;

        public ListViewModel()
        {
            EntityCollection = new ObservableCollection<BaseEntity>();
            _buzzer = new Buzzer();
            _kamikazeBuzzer = new KamikazeBuzzer();
            _mech = new Mech();
            _player = new Player();
            _spider = new Spider();

            EntityCollection.Add(_buzzer);
            EntityCollection.Add(_kamikazeBuzzer);
            EntityCollection.Add(_mech);
            EntityCollection.Add(_player);
            EntityCollection.Add(_spider);
        }
    }
}