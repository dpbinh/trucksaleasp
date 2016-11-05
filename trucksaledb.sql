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
    Name varchar(256),
    Img varchar(256)
);

create table Products
(
	Id bigint primary key identity,
    Name varchar(256),
    Img varchar(256),
    Price bigint,
    ProductGroupId bigint,
    OverallDemension varchar(256),
    InsideCargoBoxDemension varchar(256),
    FrontRearTread varchar(256),
    WheelBase varchar(256),
    GroundClearance varchar(256),
    CurbWeight varchar(256),
    LoadWeight varchar(256),
    GrossWeight varchar(256),
    NumberOfSeats varchar(256),
    CarEngine varchar(256),
    EngineType varchar(256),
    Displacement varchar(256),
    DiameterPistonStroke varchar(256),
    MaxPowerRotationSpeed varchar(256),
    MaxTorqueRotationSpeed varchar(256),
    Clutch varchar(256),
    Manual varchar(256),
    StearingSystem varchar(256),
    BrakesSystem varchar(256),
    Front varchar(256),
    Rear varchar(256),
    FrontRear varchar(256),
    HillClimbingAbility varchar(256),
    MinimumTurningRadius varchar(256),
    MaximumSpeed varchar(256),
    CapacityFuelTank varchar(256),
    SeatBelt varchar(256),
    LockDoor varchar(256),
    Damping varchar(256),
    BrakeLight varchar(256),
    Burgalar varchar(256)
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
