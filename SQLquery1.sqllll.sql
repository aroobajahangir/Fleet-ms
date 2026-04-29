USE FleetDB;
GO

-- =========================
-- VEHICLES TABLE
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Vehicles')
BEGIN
    CREATE TABLE dbo.Vehicles (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Model NVARCHAR(50),
        Number NVARCHAR(20),
        Type NVARCHAR(50),
        FuelType NVARCHAR(50),
        Status NVARCHAR(50)
    );
END
GO

-- =========================
-- DRIVERS TABLE
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Drivers')
BEGIN
    CREATE TABLE dbo.Drivers (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(50),
        LicenseNumber NVARCHAR(50),
        Contact NVARCHAR(20)
    );
END
GO

-- =========================
-- TRIPS TABLE
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Trips')
BEGIN
    CREATE TABLE dbo.Trips (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        VehicleNumber NVARCHAR(20),
        DriverName NVARCHAR(50),
        Destination NVARCHAR(100),
        Status NVARCHAR(50)
    );
END
GO

-- =========================
-- MAINTENANCE TABLE
-- =========================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Maintenance')
BEGIN
    CREATE TABLE dbo.Maintenance (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        VehicleNumber NVARCHAR(20),
        Description NVARCHAR(100),
        Cost FLOAT,
        Date DATETIME
    );
END
GO