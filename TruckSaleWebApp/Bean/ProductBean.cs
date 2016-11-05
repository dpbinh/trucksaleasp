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
            this.InsideCargoBoxDemension = product.InsideCargoBoxDemension;
            this.FrontRearTread = product.FrontRearTread;
            this.WheelBase = product.WheelBase;
            this.GroundClearance = product.GroundClearance;
            this.CurbWeight = product.CurbWeight;
            this.LoadWeight = product.LoadWeight;
            this.GrossWeight = product.GrossWeight;
            this.NumberOfSeats = product.NumberOfSeats;
            this.CarEngine = product.CarEngine;
            this.EngineType = product.EngineType;
            this.Displacement = product.Displacement;
            this.DiameterPistonStroke = product.DiameterPistonStroke;
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
            this.MinimumTurningRadius = product.MinimumTurningRadius;
            this.MaximumSpeed = product.MaximumSpeed;
            this.CapacityFuelTank = product.CapacityFuelTank;
            this.SeatBelt = product.SeatBelt;
            this.LockDoor = product.LockDoor;
            this.Damping = product.Damping;
            this.BrakeLight = product.BrakeLight;
            this.Burgalar = product.Burgalar;
        }

        public void CloneTo(Product product)
        {
            product.OverallDemension = this.OverallDemension;
            product.InsideCargoBoxDemension = this.InsideCargoBoxDemension;
            product.FrontRearTread = this.FrontRearTread;
            product.WheelBase = this.WheelBase;
            product.GroundClearance = this.GroundClearance;
            product.CurbWeight = this.CurbWeight;
            product.LoadWeight = this.LoadWeight;
            product.GrossWeight = this.GrossWeight;
            product.NumberOfSeats = this.NumberOfSeats;
            product.CarEngine = this.CarEngine;
            product.EngineType = this.EngineType;
            product.Displacement = this.Displacement;
            product.DiameterPistonStroke = this.DiameterPistonStroke;
            product.MaxPowerRotationSpeed = this.MaxPowerRotationSpeed;
            product.MaxTorqueRotationSpeed = this.MaxTorqueRotationSpeed;
            product.Clutch = this.Clutch;
            product.Manual = this.Manual;
            product.StearingSystem = this.StearingSystem;
            product.BrakesSystem = this.BrakesSystem;
            product.Front = this.Front;
            product.Rear = this.Rear;
            product.FrontRear = this.FrontRear;
            product.HillClimbingAbility = this.HillClimbingAbility;
            product.MinimumTurningRadius = this.MinimumTurningRadius;
            product.MaximumSpeed = this.MaximumSpeed;
            product.CapacityFuelTank = this.CapacityFuelTank;
            product.SeatBelt = this.SeatBelt;
            product.LockDoor = this.LockDoor;
            product.Damping = this.Damping;
            product.BrakeLight = this.BrakeLight;
            product.Burgalar = this.Burgalar;
        }

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

    }
}