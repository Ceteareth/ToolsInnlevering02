﻿using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models;
using Innlevering02.Model.Custom_Models.Property_Classes;

namespace Innlevering02.Model
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class KamikazeBuzzer : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the KamikazeBuzzer class.
        /// </summary>
        public KamikazeBuzzer()
        {
            Name = "KamikazeBuzzer";
            Health = new Health();
            Damage = new Damage();
            MovementSpeed = new MovementSpeed();
            Invincible = new Invincible();
            AddPropertiesToCollection();
        }
    }
}