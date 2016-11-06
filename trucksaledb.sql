create table Roles 
(
	Id bigint primary key identity,
    Name varchar(20)
);

create table Users
(
	Id bigint primary key identity,
    UserName varchar(256),
    Password varchar(256),
	Vcode varchar(256),
    RoleId bigint
);

create table ProductGroups
(
	Id bigint primary key,
    Name nvarchar(256),
    Img varchar(256)
);

create table Products
(
	Id bigint primary key identity,
    Name nvarchar(256),
    Img varchar(256),
    Price bigint,
    ProductGroupId bigint,
    OverallDemension nvarchar(256),
    InsideCargoBoxDemension nvarchar(256),
    FrontRearTread nvarchar(256),
    WheelBase nvarchar(256),
    GroundClearance nvarchar(256),
    CurbWeight nvarchar(256),
    LoadWeight nvarchar(256),
    GrossWeight nvarchar(256),
    NumberOfSeats nvarchar(256),
    CarEngine nvarchar(256),
    EngineType nvarchar(256),
    Displacement nvarchar(256),
    DiameterPistonStroke nvarchar(256),
    MaxPowerRotationSpeed nvarchar(256),
    MaxTorqueRotationSpeed nvarchar(256),
    Clutch nvarchar(256),
    Manual nvarchar(256),
    StearingSystem nvarchar(256),
    BrakesSystem nvarchar(256),
    Front nvarchar(256),
    Rear nvarchar(256),
    FrontRear nvarchar(256),
    HillClimbingAbility nvarchar(256),
    MinimumTurningRadius nvarchar(256),
    MaximumSpeed nvarchar(256),
    CapacityFuelTank nvarchar(256),
    SeatBelt nvarchar(256),
    LockDoor nvarchar(256),
    Damping nvarchar(256),
    BrakeLight nvarchar(256),
    Burgalar nvarchar(256)
);

create table ProductResources
(
	Id bigint primary key identity,
	resourcePath varchar(256),
	resourceType varchar(20),
	productId bigint
)

 
alter table Users
add constraint users_role foreign key(RoleId) references Roles(ID);

alter table PRODUCTs
add constraint product_groupproduct foreign key ( ProductGroupId) references ProductGroups(ID);
 

insert into Roles(NAME) values ('ADMIN');

insert into ProductGroups(ID, NAME, IMG) values(1, 'Suzuki', '/Content/img/logo/suzuki.png');
insert into ProductGroups(ID, NAME, IMG) values(2, 'Hino', '/Content/img/logo/hino.png');
insert into ProductGroups(ID, NAME, IMG) values(3, 'Hyundai', '/Content/img/logo/huyndai.png');
insert into ProductGroups(ID, NAME, IMG) values(4, 'Isuzu', '/Content/img/logo/isuzu.png');
insert into ProductGroups(ID, NAME, IMG) values(5, 'Dongfeng', '/Content/img/logo/dongfeng.png');
insert into ProductGroups(ID, NAME, IMG) values(6, 'Mitsubishi', '/Content/img/logo/misubishi.png');
insert into ProductGroups(ID, NAME, IMG) values(7, 'Veam', '/Content/img/logo/veam.png');
