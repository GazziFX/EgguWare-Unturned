using EgguWare.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EgguWare.Options.ESP
{
    public class OtherOptions
    {
        // Custom Options
        #region Bed
        public bool Claimed = true;
        public bool OnlyUnclaimed = false;
        #endregion
        #region Items
        public bool ListClumpedItems = false;
        public float DistanceThreshold = 3;
        public int CountThreshold = 5;
        #endregion
        #region Player
        public bool Weapon = true;
        public bool ViewHitboxes = true;
        #endregion
        #region Vehicle
        public bool VehicleLocked = true;
        public bool OnlyUnlocked = false;
        public bool ShowVehicleFuel = false;
        public bool ShowVehicleHealth = false;
        #endregion
        #region Storage
        public bool ShowLocked = true;
        #endregion
        #region Turrets
        public bool ShowTurretStatus = false;
        #endregion
        #region Generator
        public bool ShowGeneratorStatus;
        public bool ShowGeneratorFuel = false;
        #endregion
        #region Other
        public Dictionary<string, Color32> GlobalColors = new Dictionary<string, Color32>();
        #endregion
    }
}
