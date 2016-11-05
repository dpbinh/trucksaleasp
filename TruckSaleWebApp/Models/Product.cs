using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruckSaleWebApp.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public Nullable<long> Price { get; set; }
        public Nullable<long> ProductGroupId { get; set; }
        public string OverallDemension { get; set; }
        public string InsideCargoBoxDemension { get; set; }
        public string FrontRearTread { get; set; }
        public string WheelBase { get; set; }
        public string GroundClearance { get; set; }
        public string CurbWeight { get; set; }
        public string LoadWeight { get; set; }
        public string GrossWeight { get; set; }
        public string NumberOfSeats { get; set; }
        public string CarEngine { get; set; }
        public string EngineType { get; set; }
        public string Displacement { get; set; }
        public string DiameterPistonStroke { get; set; }
        public string MaxPowerRotationSpeed { get; set; }
        public string MaxTorqueRotationSpeed { get; set; }
        public string Clutch { get; set; }
        public string Manual { get; set; }
        public string StearingSystem { get; set; }
        public string BrakesSystem { get; set; }
        public string Front { get; set; }
        public string Rear { get; set; }
        public string FrontRear { get; set; }
        public string HillClimbingAbility { get; set; }
        public string MinimumTurningRadius { get; set; }
        public string MaximumSpeed { get; set; }
        public string CapacityFuelTank { get; set; }
        public string SeatBelt { get; set; }
        public string LockDoor { get; set; }
        public string Damping { get; set; }
        public string BrakeLight { get; set; }
        public string Burgalar { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}