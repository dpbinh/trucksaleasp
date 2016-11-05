using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Bean
{
    public class ProductBean : ProductShortInfoBean
    {
        public ProductBean()
        {

        }

        public ProductBean(Product product): base(product)
        {
            this.OverallDemension = product.OverallDemension;
            this.InsideCargBoxDemension = product.InsideCargBoxDemension;
            this.FrontRearTread = product.FrontRearTread;
            this.WheelBase = product.WheelBase;
            this.GroundClearance = product.GroundClearance;
            this.CurbWeight = product.CurbWeight;
            this.LoadWeight = product.LoadWeight;
            this.GrossWeight = product.GrossWeight;
            this.NumberOfSeats = product.NumberOfSeats;
            this.CarEngine = product.CarEngine;
            this.EnginType = product.EnginType;
            this.Displacement = product.Displacement;
            this.DiameterPistonTroke = product.DiameterPistonTroke;
            this.MaxPowerRotationSpeed = product.MaxPowerRotationSpeed;
            this.MaxTorqueRotationSpeed = product.MaxTorqueRotationSpeed;
            this.Clutch = product.Clutch;
            this.Manual = product.Manual;
            this.StearingSystem = product.StearingSystem;
            this.BrakesSystem = product.BrakesSystem;
            this.Front = product.Front;
            this.Rear = product.Rear;
            this.FrontRear = product.FrontRear;
            this.HillClimbingAbility = product.HillClimbingAbility;
            this.MaximumTuringRadius = product.MaximumTuringRadius;
            this.MaximumSpeed = product.MaximumSpeed;
            this.CapacityFuelTank = product.CapacityFuelTank;
            this.SeatBelt = product.SeatBelt;
            this.LockDoor = product.LockDoor;
            this.Damping = product.Damping;
            this.BrakeLight = product.BrakeLight;
            this.Burgalar = product.Burgalar;
        }

        public string OverallDemension { get; set; }
        public string InsideCargBoxDemension { get; set; }
        public string FrontRearTread { get; set; }
        public string WheelBase { get; set; }
        public string GroundClearance { get; set; }
        public string CurbWeight { get; set; }
        public string LoadWeight { get; set; }
        public string GrossWeight { get; set; }
        public string NumberOfSeats { get; set; }
        public string CarEngine { get; set; }
        public string EnginType { get; set; }
        public string Displacement { get; set; }
        public string DiameterPistonTroke { get; set; }
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
        public string MaximumTuringRadius { get; set; }
        public string MaximumSpeed { get; set; }
        public string CapacityFuelTank { get; set; }
        public string SeatBelt { get; set; }
        public string LockDoor { get; set; }
        public string Damping { get; set; }
        public string BrakeLight { get; set; }
        public string Burgalar { get; set; }

    }
}