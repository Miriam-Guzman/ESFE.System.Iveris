-- =====================================================
-- SCRIPT DE BASE DE DATOS - ESFE.System.Iveris
-- Sistema de Gestión para Aerolíneas Iveris
-- Compatible 100% con la Capa DAL (C# .NET)
-- =====================================================

-- =====================================================
-- BLOQUE 0: LIMPIEZA PREVIA DE PROCEDIMIENTOS ALMACENADOS
-- =====================================================

-- Aeropuertos / Asientos / Aviones
DROP PROCEDURE IF EXISTS dbo.SP_InsertarAeropuerto;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarAsiento;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarAvion;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarAvion;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarAvion;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarAvion;
DROP PROCEDURE IF EXISTS dbo.SP_ListarAvion;
DROP PROCEDURE IF EXISTS dbo.InsertarAvion;
DROP PROCEDURE IF EXISTS dbo.ActualizarAvion;
DROP PROCEDURE IF EXISTS dbo.EliminarAvion;
DROP PROCEDURE IF EXISTS dbo.BuscarAvion;

-- Boletos
DROP PROCEDURE IF EXISTS dbo.SP_InsertarBoleto;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarBoleto;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarBoleto;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarBoleto;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarBoleto;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarBoletoCodigo;
DROP PROCEDURE IF EXISTS dbo.SP_ListarBoleto;

-- Cargos / Checkin / Ciudades / Clases / Clientes
DROP PROCEDURE IF EXISTS dbo.SP_InsertarCargo;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarCheckin;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarCiudad;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarClase;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarCliente;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarCliente;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarCliente;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarCliente;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarCliente;
DROP PROCEDURE IF EXISTS dbo.SP_ListarCliente;

-- Det_Reservas / Empleados / Equipajes
DROP PROCEDURE IF EXISTS dbo.SP_InsertarDetReserva;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEmpleado;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarEmpleado;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarEmpleado;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarEmpleado;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarEmpleado;
DROP PROCEDURE IF EXISTS dbo.SP_ListarEmpleado;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEquipaje;

-- Estados
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEstBoleto;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEstCheckin;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEstFactura;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEstPago;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEstReserva;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarEstVuelo;

-- Facturas / Met_Pagos / Pagos / Paises / Pasajeros
DROP PROCEDURE IF EXISTS dbo.SP_InsertarFactura;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarFactura;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarFactura;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarFactura;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarFactura;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarFacturaNumero;
DROP PROCEDURE IF EXISTS dbo.SP_ListarFactura;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarMetPago;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarPago;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarPais;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarPago;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarPago;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarPago;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarPago;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarPagoReserva;
DROP PROCEDURE IF EXISTS dbo.SP_ListarPago;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarPasajero;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarPasajero;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarPasajero;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarPasajero;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarPasajero;
DROP PROCEDURE IF EXISTS dbo.SP_ListarPasajero;

-- Puerta / Reservas / Tipos / Tripulación / Vuelos
DROP PROCEDURE IF EXISTS dbo.SP_InsertarPuertaAbordaje;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarReserva;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarReserva;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarReserva;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarReserva;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarReserva;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarReservaCliente;
DROP PROCEDURE IF EXISTS dbo.SP_ListarReserva;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarTipoDoc;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarTipoEquipaje;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarTripulacion;
DROP PROCEDURE IF EXISTS dbo.SP_InsertarVuelo;
DROP PROCEDURE IF EXISTS dbo.SP_ActualizarVuelo;
DROP PROCEDURE IF EXISTS dbo.SP_ModificarVuelo;
DROP PROCEDURE IF EXISTS dbo.SP_EliminarVuelo;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarVuelo;
DROP PROCEDURE IF EXISTS dbo.SP_BuscarVueloNumero;
DROP PROCEDURE IF EXISTS dbo.SP_ListarVuelo;
GO

-- =====================================================
-- BLOQUE 1: CREACIÓN DE TABLAS SI NO EXISTEN
-- =====================================================

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Paises')
CREATE TABLE dbo.Paises(
    id_pais INT IDENTITY(1,1) PRIMARY KEY,
    nombre_pais VARCHAR(100) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cuidades')
CREATE TABLE dbo.Cuidades(
    id_ciudad INT IDENTITY(1,1) PRIMARY KEY,
    nombre_ciudad VARCHAR(100) NOT NULL,
    id_pais INT NOT NULL FOREIGN KEY REFERENCES dbo.Paises(id_pais)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Cargos')
CREATE TABLE dbo.Cargos(
    id_cargo INT IDENTITY(1,1) PRIMARY KEY,
    nombre_cargo VARCHAR(100) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Empleados')
CREATE TABLE dbo.Empleados(
    id_empleado INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    id_cargo INT NOT NULL FOREIGN KEY REFERENCES dbo.Cargos(id_cargo)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Clientes')
CREATE TABLE dbo.Clientes(
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    id_ciudad INT NOT NULL FOREIGN KEY REFERENCES dbo.Cuidades(id_ciudad),
    contrasena VARCHAR(255) NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Aviones')
CREATE TABLE dbo.Aviones(
    id_avion INT IDENTITY(1,1) PRIMARY KEY,
    modelo VARCHAR(100) NOT NULL,
    capacidad INT NOT NULL,
    matricula VARCHAR(20) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Est_Vuelo')
CREATE TABLE dbo.Est_Vuelo(
    id_est_vuelo INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Aeropuertos')
CREATE TABLE dbo.Aeropuertos(
    id_aeropuerto INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(150) NOT NULL,
    codigo_iata CHAR(3) NOT NULL,
    id_ciudad INT NOT NULL FOREIGN KEY REFERENCES dbo.Cuidades(id_ciudad)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Puerta_Abordaje')
CREATE TABLE dbo.Puerta_Abordaje(
    id_puerta INT IDENTITY(1,1) PRIMARY KEY,
    codigo_puerta VARCHAR(10) NOT NULL,
    id_aeropuerto INT NOT NULL FOREIGN KEY REFERENCES dbo.Aeropuertos(id_aeropuerto)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Vuelos')
CREATE TABLE dbo.Vuelos(
    id_vuelo INT IDENTITY(1,1) PRIMARY KEY,
    numero_vuelo VARCHAR(20) NOT NULL,
    fecha_salida DATETIME NOT NULL,
    fecha_llegada DATETIME NOT NULL,
    id_aeropuerto_origen INT NOT NULL FOREIGN KEY REFERENCES dbo.Aeropuertos(id_aeropuerto),
    id_aeropuerto_destino INT NOT NULL FOREIGN KEY REFERENCES dbo.Aeropuertos(id_aeropuerto),
    id_avion INT NOT NULL FOREIGN KEY REFERENCES dbo.Aviones(id_avion),
    id_est_vuelo INT NOT NULL FOREIGN KEY REFERENCES dbo.Est_Vuelo(id_est_vuelo),
    id_puerta INT NOT NULL FOREIGN KEY REFERENCES dbo.Puerta_Abordaje(id_puerta)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Clases')
CREATE TABLE dbo.Clases(
    id_clase INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Asientos')
CREATE TABLE dbo.Asientos(
    id_asiento INT IDENTITY(1,1) PRIMARY KEY,
    numero_asiento VARCHAR(10) NOT NULL,
    id_avion INT NOT NULL FOREIGN KEY REFERENCES dbo.Aviones(id_avion),
    id_clase INT NOT NULL FOREIGN KEY REFERENCES dbo.Clases(id_clase)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Pasajeros')
CREATE TABLE dbo.Pasajeros(
    id_pasajero INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    pasaporte VARCHAR(20) NOT NULL,
    id_ciudad INT NOT NULL FOREIGN KEY REFERENCES dbo.Cuidades(id_ciudad)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Est_Boletos')
CREATE TABLE dbo.Est_Boletos(
    id_est_boleto INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Boletos')
CREATE TABLE dbo.Boletos(
    id_boleto INT IDENTITY(1,1) PRIMARY KEY,
    codigo_boleto VARCHAR(20) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    id_vuelo INT NOT NULL FOREIGN KEY REFERENCES dbo.Vuelos(id_vuelo),
    id_asiento INT NOT NULL FOREIGN KEY REFERENCES dbo.Asientos(id_asiento),
    id_pasajero INT NOT NULL FOREIGN KEY REFERENCES dbo.Pasajeros(id_pasajero),
    id_est_boleto INT NOT NULL FOREIGN KEY REFERENCES dbo.Est_Boletos(id_est_boleto)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Est_Reservas')
CREATE TABLE dbo.Est_Reservas(
    id_est_reserva INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Reservas')
CREATE TABLE dbo.Reservas(
    id_reserva INT IDENTITY(1,1) PRIMARY KEY,
    fecha_reserva DATETIME NOT NULL,
    id_cliente INT NOT NULL FOREIGN KEY REFERENCES dbo.Clientes(id_cliente),
    id_est_reserva INT NOT NULL FOREIGN KEY REFERENCES dbo.Est_Reservas(id_est_reserva)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Det_Reservas')
CREATE TABLE dbo.Det_Reservas(
    id_det_reserva INT IDENTITY(1,1) PRIMARY KEY,
    id_reserva INT NOT NULL FOREIGN KEY REFERENCES dbo.Reservas(id_reserva),
    id_boleto INT NOT NULL FOREIGN KEY REFERENCES dbo.Boletos(id_boleto)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Est_Pagos')
CREATE TABLE dbo.Est_Pagos(
    id_est_pago INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Met_Pagos')
CREATE TABLE dbo.Met_Pagos(
    id_met_pago INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Pagos')
CREATE TABLE dbo.Pagos(
    id_pago INT IDENTITY(1,1) PRIMARY KEY,
    fecha_pago DATETIME NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    id_reserva INT NOT NULL FOREIGN KEY REFERENCES dbo.Reservas(id_reserva),
    id_est_pago INT NOT NULL FOREIGN KEY REFERENCES dbo.Est_Pagos(id_est_pago),
    id_met_pago INT NOT NULL FOREIGN KEY REFERENCES dbo.Met_Pagos(id_met_pago)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Est_Facturas')
CREATE TABLE dbo.Est_Facturas(
    id_est_factura INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tipo_Doc')
CREATE TABLE dbo.Tipo_Doc(
    id_tipo_doc INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Facturas')
CREATE TABLE dbo.Facturas(
    id_factura INT IDENTITY(1,1) PRIMARY KEY,
    numero_factura VARCHAR(20) NOT NULL,
    fecha_emision DATETIME NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    id_pago INT NOT NULL FOREIGN KEY REFERENCES dbo.Pagos(id_pago),
    id_est_factura INT NOT NULL FOREIGN KEY REFERENCES dbo.Est_Facturas(id_est_factura),
    id_tipo_doc INT NOT NULL FOREIGN KEY REFERENCES dbo.Tipo_Doc(id_tipo_doc)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Est_Checkin')
CREATE TABLE dbo.Est_Checkin(
    id_est_checkin INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Checkin')
CREATE TABLE dbo.Checkin(
    id_checkin INT IDENTITY(1,1) PRIMARY KEY,
    fecha_checkin DATETIME NOT NULL,
    id_boleto INT NOT NULL FOREIGN KEY REFERENCES dbo.Boletos(id_boleto),
    id_est_checkin INT NOT NULL FOREIGN KEY REFERENCES dbo.Est_Checkin(id_est_checkin)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tipo_Equipaje')
CREATE TABLE dbo.Tipo_Equipaje(
    id_tipo_equipaje INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Equipajes')
CREATE TABLE dbo.Equipajes(
    id_equipaje INT IDENTITY(1,1) PRIMARY KEY,
    peso_kg DECIMAL(5,2) NOT NULL,
    id_boleto INT NOT NULL FOREIGN KEY REFERENCES dbo.Boletos(id_boleto),
    id_tipo_equipaje INT NOT NULL FOREIGN KEY REFERENCES dbo.Tipo_Equipaje(id_tipo_equipaje)
);

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tripulacion')
CREATE TABLE dbo.Tripulacion(
    id_tripulacion INT IDENTITY(1,1) PRIMARY KEY,
    id_vuelo INT NOT NULL FOREIGN KEY REFERENCES dbo.Vuelos(id_vuelo),
    id_empleado INT NOT NULL FOREIGN KEY REFERENCES dbo.Empleados(id_empleado)
);
GO

-- =====================================================
-- BLOQUE 2: PROCEDIMIENTOS ALMACENADOS (COMPATIBILIDAD 100%)
-- =====================================================

-- -----------------------------------------------------
-- 1. AVIONES
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarAvion
    @modelo VARCHAR(100),
    @capacidad INT,
    @matricula VARCHAR(20)
AS
BEGIN
    INSERT INTO dbo.Aviones (modelo, capacidad, matricula)
    VALUES (@modelo, @capacidad, @matricula);
END;
GO

CREATE PROCEDURE dbo.InsertarAvion
    @modelo VARCHAR(100),
    @capacidad INT,
    @matricula VARCHAR(20)
AS
BEGIN
    EXEC dbo.SP_InsertarAvion @modelo, @capacidad, @matricula;
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarAvion
    @id_avion INT,
    @modelo VARCHAR(100),
    @capacidad INT,
    @matricula VARCHAR(20)
AS
BEGIN
    UPDATE dbo.Aviones
    SET modelo = @modelo, capacidad = @capacidad, matricula = @matricula
    WHERE id_avion = @id_avion;
END;
GO

CREATE PROCEDURE dbo.ActualizarAvion
    @id_avion INT,
    @modelo VARCHAR(100),
    @capacidad INT,
    @matricula VARCHAR(20)
AS
BEGIN
    EXEC dbo.SP_ActualizarAvion @id_avion, @modelo, @capacidad, @matricula;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarAvion
    @id_avion INT
AS
BEGIN
    DELETE FROM dbo.Aviones WHERE id_avion = @id_avion;
END;
GO

CREATE PROCEDURE dbo.EliminarAvion
    @id_avion INT
AS
BEGIN
    EXEC dbo.SP_EliminarAvion @id_avion;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarAvion
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_avion, modelo, capacidad, matricula
    FROM dbo.Aviones
    WHERE modelo LIKE '%' + @criterio + '%' 
       OR matricula LIKE '%' + @criterio + '%'
       OR (ISNUMERIC(@criterio) = 1 AND id_avion = CAST(@criterio AS INT));
END;
GO

CREATE PROCEDURE dbo.BuscarAvion
    @criterio VARCHAR(100)
AS
BEGIN
    EXEC dbo.SP_BuscarAvion @criterio;
END;
GO

CREATE PROCEDURE dbo.SP_ListarAvion
AS
BEGIN
    SELECT id_avion, modelo, capacidad, matricula FROM dbo.Aviones;
END;
GO

-- -----------------------------------------------------
-- 2. BOLETOS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarBoleto
    @codigo_boleto VARCHAR(20),
    @precio DECIMAL(10,2),
    @id_vuelo INT,
    @id_asiento INT,
    @id_pasajero INT,
    @id_est_boleto INT
AS
BEGIN
    INSERT INTO dbo.Boletos (codigo_boleto, precio, id_vuelo, id_asiento, id_pasajero, id_est_boleto)
    VALUES (@codigo_boleto, @precio, @id_vuelo, @id_asiento, @id_pasajero, @id_est_boleto);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarBoleto
    @id_boleto INT,
    @codigo_boleto VARCHAR(20),
    @precio DECIMAL(10,2),
    @id_vuelo INT,
    @id_asiento INT,
    @id_pasajero INT,
    @id_est_boleto INT
AS
BEGIN
    UPDATE dbo.Boletos
    SET codigo_boleto = @codigo_boleto,
        precio = @precio,
        id_vuelo = @id_vuelo,
        id_asiento = @id_asiento,
        id_pasajero = @id_pasajero,
        id_est_boleto = @id_est_boleto
    WHERE id_boleto = @id_boleto;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarBoleto
    @id_boleto INT,
    @codigo_boleto VARCHAR(20),
    @precio DECIMAL(10,2),
    @id_vuelo INT,
    @id_asiento INT,
    @id_pasajero INT,
    @id_est_boleto INT
AS
BEGIN
    EXEC dbo.SP_ActualizarBoleto @id_boleto, @codigo_boleto, @precio, @id_vuelo, @id_asiento, @id_pasajero, @id_est_boleto;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarBoleto
    @id_boleto INT
AS
BEGIN
    DELETE FROM dbo.Boletos WHERE id_boleto = @id_boleto;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarBoletoCodigo
    @codigo_boleto VARCHAR(20)
AS
BEGIN
    SELECT id_boleto, codigo_boleto, precio, id_vuelo, id_asiento, id_pasajero, id_est_boleto
    FROM dbo.Boletos
    WHERE codigo_boleto LIKE '%' + @codigo_boleto + '%';
END;
GO

CREATE PROCEDURE dbo.SP_BuscarBoleto
    @id_boleto INT = NULL,
    @codigo_boleto VARCHAR(20) = NULL
AS
BEGIN
    SELECT id_boleto, codigo_boleto, precio, id_vuelo, id_asiento, id_pasajero, id_est_boleto
    FROM dbo.Boletos
    WHERE (@id_boleto IS NULL OR id_boleto = @id_boleto)
      AND (@codigo_boleto IS NULL OR codigo_boleto LIKE '%' + @codigo_boleto + '%');
END;
GO

CREATE PROCEDURE dbo.SP_ListarBoleto
AS
BEGIN
    SELECT id_boleto, codigo_boleto, precio, id_vuelo, id_asiento, id_pasajero, id_est_boleto FROM dbo.Boletos;
END;
GO

-- -----------------------------------------------------
-- 3. CLIENTES
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarCliente
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(150),
    @telefono VARCHAR(20),
    @id_ciudad INT,
    @contrasena VARCHAR(255) = NULL
AS
BEGIN
    INSERT INTO dbo.Clientes (nombre, apellido, email, telefono, id_ciudad, contrasena)
    VALUES (@nombre, @apellido, @email, @telefono, @id_ciudad, @contrasena);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarCliente
    @id_cliente INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(150),
    @telefono VARCHAR(20),
    @id_ciudad INT,
    @contrasena VARCHAR(255) = NULL
AS
BEGIN
    UPDATE dbo.Clientes
    SET nombre = @nombre,
        apellido = @apellido,
        email = @email,
        telefono = @telefono,
        id_ciudad = @id_ciudad,
        contrasena = COALESCE(@contrasena, contrasena)
    WHERE id_cliente = @id_cliente;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarCliente
    @id_cliente INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(150),
    @telefono VARCHAR(20),
    @id_ciudad INT,
    @contrasena VARCHAR(255) = NULL
AS
BEGIN
    EXEC dbo.SP_ActualizarCliente @id_cliente, @nombre, @apellido, @email, @telefono, @id_ciudad, @contrasena;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarCliente
    @id_cliente INT
AS
BEGIN
    DELETE FROM dbo.Clientes WHERE id_cliente = @id_cliente;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarCliente
    @criterio VARCHAR(100) = NULL,
    @id_cliente INT = NULL
AS
BEGIN
    IF @id_cliente IS NOT NULL
    BEGIN
        SELECT id_cliente, nombre, apellido, email, telefono, id_ciudad, contrasena
        FROM dbo.Clientes
        WHERE id_cliente = @id_cliente;
    END
    ELSE
    BEGIN
        SELECT id_cliente, nombre, apellido, email, telefono, id_ciudad, contrasena
        FROM dbo.Clientes
        WHERE nombre LIKE '%' + @criterio + '%'
           OR apellido LIKE '%' + @criterio + '%'
           OR email LIKE '%' + @criterio + '%'
           OR telefono LIKE '%' + @criterio + '%'
           OR (ISNUMERIC(@criterio) = 1 AND id_cliente = CAST(@criterio AS INT));
    END
END;
GO

CREATE PROCEDURE dbo.SP_ListarCliente
AS
BEGIN
    SELECT id_cliente, nombre, apellido, email, telefono, id_ciudad, contrasena FROM dbo.Clientes;
END;
GO

CREATE PROCEDURE dbo.SP_IniciarSesionCliente
    @email VARCHAR(150),
    @contrasena VARCHAR(255)
AS
BEGIN
    SELECT id_cliente, nombre, apellido, email, telefono, id_ciudad, contrasena
    FROM dbo.Clientes
    WHERE email = @email AND contrasena = @contrasena;
END;
GO

CREATE PROCEDURE dbo.SP_ExisteEmailCliente
    @email VARCHAR(150)
AS
BEGIN
    SELECT COUNT(*) FROM dbo.Clientes WHERE email = @email;
END;
GO

CREATE PROCEDURE dbo.SP_ListarCuidades
AS
BEGIN
    SELECT id_ciudad, nombre_ciudad, id_pais FROM dbo.Cuidades;
END;
GO

-- -----------------------------------------------------
-- 4. EMPLEADOS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarEmpleado
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(150),
    @telefono VARCHAR(20),
    @id_cargo INT
AS
BEGIN
    INSERT INTO dbo.Empleados (nombre, apellido, email, telefono, id_cargo)
    VALUES (@nombre, @apellido, @email, @telefono, @id_cargo);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarEmpleado
    @id_empleado INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(150),
    @telefono VARCHAR(20),
    @id_cargo INT
AS
BEGIN
    UPDATE dbo.Empleados
    SET nombre = @nombre,
        apellido = @apellido,
        email = @email,
        telefono = @telefono,
        id_cargo = @id_cargo
    WHERE id_empleado = @id_empleado;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarEmpleado
    @id_empleado INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @email VARCHAR(150),
    @telefono VARCHAR(20),
    @id_cargo INT
AS
BEGIN
    EXEC dbo.SP_ActualizarEmpleado @id_empleado, @nombre, @apellido, @email, @telefono, @id_cargo;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarEmpleado
    @id_empleado INT
AS
BEGIN
    DELETE FROM dbo.Empleados WHERE id_empleado = @id_empleado;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarEmpleado
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_empleado, nombre, apellido, email, telefono, id_cargo
    FROM dbo.Empleados
    WHERE nombre LIKE '%' + @criterio + '%'
       OR apellido LIKE '%' + @criterio + '%'
       OR email LIKE '%' + @criterio + '%'
       OR (ISNUMERIC(@criterio) = 1 AND id_empleado = CAST(@criterio AS INT));
END;
GO

CREATE PROCEDURE dbo.SP_ListarEmpleado
AS
BEGIN
    SELECT id_empleado, nombre, apellido, email, telefono, id_cargo FROM dbo.Empleados;
END;
GO

-- -----------------------------------------------------
-- 5. FACTURAS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarFactura
    @numero_factura VARCHAR(20),
    @fecha_emision DATETIME,
    @total DECIMAL(10,2),
    @id_pago INT,
    @id_est_factura INT,
    @id_tipo_doc INT
AS
BEGIN
    INSERT INTO dbo.Facturas (numero_factura, fecha_emision, total, id_pago, id_est_factura, id_tipo_doc)
    VALUES (@numero_factura, @fecha_emision, @total, @id_pago, @id_est_factura, @id_tipo_doc);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarFactura
    @id_factura INT,
    @numero_factura VARCHAR(20),
    @fecha_emision DATETIME,
    @total DECIMAL(10,2),
    @id_pago INT,
    @id_est_factura INT,
    @id_tipo_doc INT
AS
BEGIN
    UPDATE dbo.Facturas
    SET numero_factura = @numero_factura,
        fecha_emision = @fecha_emision,
        total = @total,
        id_pago = @id_pago,
        id_est_factura = @id_est_factura,
        id_tipo_doc = @id_tipo_doc
    WHERE id_factura = @id_factura;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarFactura
    @id_factura INT,
    @numero_factura VARCHAR(20),
    @fecha_emision DATETIME,
    @total DECIMAL(10,2),
    @id_pago INT,
    @id_est_factura INT,
    @id_tipo_doc INT
AS
BEGIN
    EXEC dbo.SP_ActualizarFactura @id_factura, @numero_factura, @fecha_emision, @total, @id_pago, @id_est_factura, @id_tipo_doc;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarFactura
    @id_factura INT
AS
BEGIN
    DELETE FROM dbo.Facturas WHERE id_factura = @id_factura;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarFacturaNumero
    @numero_factura VARCHAR(20)
AS
BEGIN
    SELECT id_factura, numero_factura, fecha_emision, total, id_pago, id_est_factura, id_tipo_doc
    FROM dbo.Facturas
    WHERE numero_factura LIKE '%' + @numero_factura + '%';
END;
GO

CREATE PROCEDURE dbo.SP_BuscarFactura
    @id_factura INT = NULL,
    @numero_factura VARCHAR(20) = NULL
AS
BEGIN
    SELECT id_factura, numero_factura, fecha_emision, total, id_pago, id_est_factura, id_tipo_doc
    FROM dbo.Facturas
    WHERE (@id_factura IS NULL OR id_factura = @id_factura)
      AND (@numero_factura IS NULL OR numero_factura LIKE '%' + @numero_factura + '%');
END;
GO

CREATE PROCEDURE dbo.SP_ListarFactura
AS
BEGIN
    SELECT id_factura, numero_factura, fecha_emision, total, id_pago, id_est_factura, id_tipo_doc FROM dbo.Facturas;
END;
GO

-- -----------------------------------------------------
-- 6. PAGOS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarPago
    @fecha_pago DATETIME,
    @monto DECIMAL(10,2),
    @id_reserva INT,
    @id_est_pago INT,
    @id_met_pago INT
AS
BEGIN
    INSERT INTO dbo.Pagos (fecha_pago, monto, id_reserva, id_est_pago, id_met_pago)
    VALUES (@fecha_pago, @monto, @id_reserva, @id_est_pago, @id_met_pago);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarPago
    @id_pago INT,
    @fecha_pago DATETIME,
    @monto DECIMAL(10,2),
    @id_reserva INT,
    @id_est_pago INT,
    @id_met_pago INT
AS
BEGIN
    UPDATE dbo.Pagos
    SET fecha_pago = @fecha_pago,
        monto = @monto,
        id_reserva = @id_reserva,
        id_est_pago = @id_est_pago,
        id_met_pago = @id_met_pago
    WHERE id_pago = @id_pago;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarPago
    @id_pago INT,
    @fecha_pago DATETIME,
    @monto DECIMAL(10,2),
    @id_reserva INT,
    @id_est_pago INT,
    @id_met_pago INT
AS
BEGIN
    EXEC dbo.SP_ActualizarPago @id_pago, @fecha_pago, @monto, @id_reserva, @id_est_pago, @id_met_pago;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarPago
    @id_pago INT
AS
BEGIN
    DELETE FROM dbo.Pagos WHERE id_pago = @id_pago;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarPagoReserva
    @id_reserva INT
AS
BEGIN
    SELECT id_pago, fecha_pago, monto, id_reserva, id_est_pago, id_met_pago
    FROM dbo.Pagos
    WHERE id_reserva = @id_reserva;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarPago
    @id_pago INT = NULL,
    @id_reserva INT = NULL
AS
BEGIN
    SELECT id_pago, fecha_pago, monto, id_reserva, id_est_pago, id_met_pago
    FROM dbo.Pagos
    WHERE (@id_pago IS NULL OR id_pago = @id_pago)
      AND (@id_reserva IS NULL OR id_reserva = @id_reserva);
END;
GO

CREATE PROCEDURE dbo.SP_ListarPago
AS
BEGIN
    SELECT id_pago, fecha_pago, monto, id_reserva, id_est_pago, id_met_pago FROM dbo.Pagos;
END;
GO

-- -----------------------------------------------------
-- 7. PASAJEROS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarPasajero
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @pasaporte VARCHAR(20),
    @id_ciudad INT
AS
BEGIN
    INSERT INTO dbo.Pasajeros (nombre, apellido, pasaporte, id_ciudad)
    VALUES (@nombre, @apellido, @pasaporte, @id_ciudad);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarPasajero
    @id_pasajero INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @pasaporte VARCHAR(20),
    @id_ciudad INT
AS
BEGIN
    UPDATE dbo.Pasajeros
    SET nombre = @nombre,
        apellido = @apellido,
        pasaporte = @pasaporte,
        id_ciudad = @id_ciudad
    WHERE id_pasajero = @id_pasajero;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarPasajero
    @id_pasajero INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @pasaporte VARCHAR(20),
    @id_ciudad INT
AS
BEGIN
    EXEC dbo.SP_ActualizarPasajero @id_pasajero, @nombre, @apellido, @pasaporte, @id_ciudad;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarPasajero
    @id_pasajero INT
AS
BEGIN
    DELETE FROM dbo.Pasajeros WHERE id_pasajero = @id_pasajero;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarPasajero
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_pasajero, nombre, apellido, pasaporte, id_ciudad
    FROM dbo.Pasajeros
    WHERE nombre LIKE '%' + @criterio + '%'
       OR apellido LIKE '%' + @criterio + '%'
       OR pasaporte LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND id_pasajero = TRY_CAST(@criterio AS INT));
END;
GO

CREATE PROCEDURE dbo.SP_ListarPasajero
AS
BEGIN
    SELECT id_pasajero, nombre, apellido, pasaporte, id_ciudad FROM dbo.Pasajeros;
END;
GO

-- -----------------------------------------------------
-- 8. RESERVAS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarReserva
    @fecha_reserva DATETIME,
    @id_cliente INT,
    @id_est_reserva INT
AS
BEGIN
    INSERT INTO dbo.Reservas (fecha_reserva, id_cliente, id_est_reserva)
    VALUES (@fecha_reserva, @id_cliente, @id_est_reserva);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarReserva
    @id_reserva INT,
    @fecha_reserva DATETIME,
    @id_cliente INT,
    @id_est_reserva INT
AS
BEGIN
    UPDATE dbo.Reservas
    SET fecha_reserva = @fecha_reserva,
        id_cliente = @id_cliente,
        id_est_reserva = @id_est_reserva
    WHERE id_reserva = @id_reserva;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarReserva
    @id_reserva INT,
    @fecha_reserva DATETIME,
    @id_cliente INT,
    @id_est_reserva INT
AS
BEGIN
    EXEC dbo.SP_ActualizarReserva @id_reserva, @fecha_reserva, @id_cliente, @id_est_reserva;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarReserva
    @id_reserva INT
AS
BEGIN
    DELETE FROM dbo.Reservas WHERE id_reserva = @id_reserva;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarReservaCliente
    @id_cliente INT
AS
BEGIN
    SELECT id_reserva, fecha_reserva, id_cliente, id_est_reserva
    FROM dbo.Reservas
    WHERE id_cliente = @id_cliente;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarReserva
    @id_reserva INT = NULL,
    @id_cliente INT = NULL
AS
BEGIN
    SELECT id_reserva, fecha_reserva, id_cliente, id_est_reserva
    FROM dbo.Reservas
    WHERE (@id_reserva IS NULL OR id_reserva = @id_reserva)
      AND (@id_cliente IS NULL OR id_cliente = @id_cliente);
END;
GO

CREATE PROCEDURE dbo.SP_ListarReserva
AS
BEGIN
    SELECT id_reserva, fecha_reserva, id_cliente, id_est_reserva FROM dbo.Reservas;
END;
GO

-- -----------------------------------------------------
-- 9. VUELOS
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarVuelo
    @numero_vuelo VARCHAR(20),
    @fecha_salida DATETIME,
    @fecha_llegada DATETIME,
    @id_aeropuerto_origen INT,
    @id_aeropuerto_destino INT,
    @id_avion INT,
    @id_est_vuelo INT,
    @id_puerta INT
AS
BEGIN
    INSERT INTO dbo.Vuelos (numero_vuelo, fecha_salida, fecha_llegada, id_aeropuerto_origen, id_aeropuerto_destino, id_avion, id_est_vuelo, id_puerta)
    VALUES (@numero_vuelo, @fecha_salida, @fecha_llegada, @id_aeropuerto_origen, @id_aeropuerto_destino, @id_avion, @id_est_vuelo, @id_puerta);
END;
GO

CREATE PROCEDURE dbo.SP_ActualizarVuelo
    @id_vuelo INT,
    @numero_vuelo VARCHAR(20),
    @fecha_salida DATETIME,
    @fecha_llegada DATETIME,
    @id_aeropuerto_origen INT,
    @id_aeropuerto_destino INT,
    @id_avion INT,
    @id_est_vuelo INT,
    @id_puerta INT
AS
BEGIN
    UPDATE dbo.Vuelos
    SET numero_vuelo = @numero_vuelo,
        fecha_salida = @fecha_salida,
        fecha_llegada = @fecha_llegada,
        id_aeropuerto_origen = @id_aeropuerto_origen,
        id_aeropuerto_destino = @id_aeropuerto_destino,
        id_avion = @id_avion,
        id_est_vuelo = @id_est_vuelo,
        id_puerta = @id_puerta
    WHERE id_vuelo = @id_vuelo;
END;
GO

CREATE PROCEDURE dbo.SP_ModificarVuelo
    @id_vuelo INT,
    @numero_vuelo VARCHAR(20),
    @fecha_salida DATETIME,
    @fecha_llegada DATETIME,
    @id_aeropuerto_origen INT,
    @id_aeropuerto_destino INT,
    @id_avion INT,
    @id_est_vuelo INT,
    @id_puerta INT
AS
BEGIN
    EXEC dbo.SP_ActualizarVuelo @id_vuelo, @numero_vuelo, @fecha_salida, @fecha_llegada, @id_aeropuerto_origen, @id_aeropuerto_destino, @id_avion, @id_est_vuelo, @id_puerta;
END;
GO

CREATE PROCEDURE dbo.SP_EliminarVuelo
    @id_vuelo INT
AS
BEGIN
    DELETE FROM dbo.Vuelos WHERE id_vuelo = @id_vuelo;
END;
GO

CREATE PROCEDURE dbo.SP_BuscarVueloNumero
    @numero_vuelo VARCHAR(20)
AS
BEGIN
    SELECT id_vuelo, numero_vuelo, fecha_salida, fecha_llegada, id_aeropuerto_origen, id_aeropuerto_destino, id_avion, id_est_vuelo, id_puerta
    FROM dbo.Vuelos
    WHERE numero_vuelo LIKE '%' + @numero_vuelo + '%';
END;
GO

CREATE PROCEDURE dbo.SP_BuscarVuelo
    @id_vuelo INT = NULL,
    @numero_vuelo VARCHAR(20) = NULL
AS
BEGIN
    SELECT id_vuelo, numero_vuelo, fecha_salida, fecha_llegada, id_aeropuerto_origen, id_aeropuerto_destino, id_avion, id_est_vuelo, id_puerta
    FROM dbo.Vuelos
    WHERE (@id_vuelo IS NULL OR id_vuelo = @id_vuelo)
      AND (@numero_vuelo IS NULL OR numero_vuelo LIKE '%' + @numero_vuelo + '%');
END;
GO

CREATE PROCEDURE dbo.SP_ListarVuelo
AS
BEGIN
    SELECT id_vuelo, numero_vuelo, fecha_salida, fecha_llegada, id_aeropuerto_origen, id_aeropuerto_destino, id_avion, id_est_vuelo, id_puerta FROM dbo.Vuelos;
END;
GO

-- -----------------------------------------------------
-- 10. PROCEDIMIENTOS AUXILIARES
-- -----------------------------------------------------
CREATE PROCEDURE dbo.SP_InsertarAeropuerto
    @nombre VARCHAR(150),
    @codigo_iata CHAR(3),
    @id_ciudad INT
AS
BEGIN
    INSERT INTO dbo.Aeropuertos (nombre, codigo_iata, id_ciudad)
    VALUES (@nombre, @codigo_iata, @id_ciudad);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarAsiento
    @numero_asiento VARCHAR(10),
    @id_avion INT,
    @id_clase INT
AS
BEGIN
    INSERT INTO dbo.Asientos (numero_asiento, id_avion, id_clase)
    VALUES (@numero_asiento, @id_avion, @id_clase);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarCargo
    @nombre_cargo VARCHAR(100)
AS
BEGIN
    INSERT INTO dbo.Cargos (nombre_cargo)
    VALUES (@nombre_cargo);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarCheckin
    @fecha_checkin DATETIME,
    @id_boleto INT,
    @id_est_checkin INT
AS
BEGIN
    INSERT INTO dbo.Checkin (fecha_checkin, id_boleto, id_est_checkin)
    VALUES (@fecha_checkin, @id_boleto, @id_est_checkin);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarCiudad
    @nombre_ciudad VARCHAR(100),
    @id_pais INT
AS
BEGIN
    INSERT INTO dbo.Cuidades (nombre_ciudad, id_pais)
    VALUES (@nombre_ciudad, @id_pais);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarClase
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Clases (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarDetReserva
    @id_reserva INT,
    @id_boleto INT
AS
BEGIN
    INSERT INTO dbo.Det_Reservas (id_reserva, id_boleto)
    VALUES (@id_reserva, @id_boleto);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEquipaje
    @peso_kg DECIMAL(5,2),
    @id_boleto INT,
    @id_tipo_equipaje INT
AS
BEGIN
    INSERT INTO dbo.Equipajes (peso_kg, id_boleto, id_tipo_equipaje)
    VALUES (@peso_kg, @id_boleto, @id_tipo_equipaje);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEstBoleto
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Est_Boletos (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEstCheckin
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Est_Checkin (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEstFactura
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Est_Facturas (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEstPago
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Est_Pagos (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEstReserva
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Est_Reservas (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarEstVuelo
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Est_Vuelo (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarMetPago
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Met_Pagos (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarPais
    @nombre_pais VARCHAR(100)
AS
BEGIN
    INSERT INTO dbo.Paises (nombre_pais)
    VALUES (@nombre_pais);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarPuertaAbordaje
    @codigo_puerta VARCHAR(10),
    @id_aeropuerto INT
AS
BEGIN
    INSERT INTO dbo.Puerta_Abordaje (codigo_puerta, id_aeropuerto)
    VALUES (@codigo_puerta, @id_aeropuerto);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarTipoDoc
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Tipo_Doc (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarTipoEquipaje
    @descripcion VARCHAR(50)
AS
BEGIN
    INSERT INTO dbo.Tipo_Equipaje (descripcion)
    VALUES (@descripcion);
END;
GO

CREATE PROCEDURE dbo.SP_InsertarTripulacion
    @id_vuelo INT,
    @id_empleado INT
AS
BEGIN
    INSERT INTO dbo.Tripulacion (id_vuelo, id_empleado)
    VALUES (@id_vuelo, @id_empleado);
END;
GO

-- -----------------------------------------------------
-- PROCEDIMIENTOS ADICIONALES PARA DESTINOS, VUELOS Y PAGOS DETALLE
-- -----------------------------------------------------

CREATE OR ALTER PROCEDURE dbo.SP_ListarAeropuerto
AS
BEGIN
    SELECT a.id_aeropuerto, a.nombre, a.codigo_iata, a.id_ciudad, c.nombre_ciudad, p.nombre_pais
    FROM dbo.Aeropuertos a
    INNER JOIN dbo.Cuidades c ON a.id_ciudad = c.id_ciudad
    INNER JOIN dbo.Paises p ON c.id_pais = p.id_pais;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_BuscarAeropuerto
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT a.id_aeropuerto, a.nombre, a.codigo_iata, a.id_ciudad, c.nombre_ciudad, p.nombre_pais
    FROM dbo.Aeropuertos a
    INNER JOIN dbo.Cuidades c ON a.id_ciudad = c.id_ciudad
    INNER JOIN dbo.Paises p ON c.id_pais = p.id_pais
    WHERE a.nombre LIKE '%' + @criterio + '%'
       OR a.codigo_iata LIKE '%' + @criterio + '%'
       OR c.nombre_ciudad LIKE '%' + @criterio + '%'
       OR p.nombre_pais LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND a.id_aeropuerto = TRY_CAST(@criterio AS INT));
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ActualizarAeropuerto
    @id_aeropuerto INT,
    @nombre VARCHAR(150),
    @codigo_iata CHAR(3),
    @id_ciudad INT
AS
BEGIN
    UPDATE dbo.Aeropuertos
    SET nombre = @nombre,
        codigo_iata = @codigo_iata,
        id_ciudad = @id_ciudad
    WHERE id_aeropuerto = @id_aeropuerto;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_EliminarAeropuerto
    @id_aeropuerto INT
AS
BEGIN
    DELETE FROM dbo.Aeropuertos WHERE id_aeropuerto = @id_aeropuerto;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarVuelosDetalle
AS
BEGIN
    SELECT 
        v.id_vuelo,
        v.numero_vuelo,
        ao.nombre + ' (' + ao.codigo_iata + ')' AS Origen,
        ad.nombre + ' (' + ad.codigo_iata + ')' AS Destino,
        v.fecha_salida AS Hora,
        v.fecha_llegada,
        av.modelo + ' (' + av.matricula + ')' AS AvionAsignado,
        ev.descripcion AS Estado,
        pa.codigo_puerta AS Puerta,
        v.id_aeropuerto_origen,
        v.id_aeropuerto_destino,
        v.id_avion,
        v.id_est_vuelo,
        v.id_puerta
    FROM dbo.Vuelos v
    INNER JOIN dbo.Aeropuertos ao ON v.id_aeropuerto_origen = ao.id_aeropuerto
    INNER JOIN dbo.Aeropuertos ad ON v.id_aeropuerto_destino = ad.id_aeropuerto
    INNER JOIN dbo.Aviones av ON v.id_avion = av.id_avion
    INNER JOIN dbo.Est_Vuelo ev ON v.id_est_vuelo = ev.id_est_vuelo
    INNER JOIN dbo.Puerta_Abordaje pa ON v.id_puerta = pa.id_puerta;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_BuscarVuelosDetalle
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT 
        v.id_vuelo,
        v.numero_vuelo,
        ao.nombre + ' (' + ao.codigo_iata + ')' AS Origen,
        ad.nombre + ' (' + ad.codigo_iata + ')' AS Destino,
        v.fecha_salida AS Hora,
        v.fecha_llegada,
        av.modelo + ' (' + av.matricula + ')' AS AvionAsignado,
        ev.descripcion AS Estado,
        pa.codigo_puerta AS Puerta,
        v.id_aeropuerto_origen,
        v.id_aeropuerto_destino,
        v.id_avion,
        v.id_est_vuelo,
        v.id_puerta
    FROM dbo.Vuelos v
    INNER JOIN dbo.Aeropuertos ao ON v.id_aeropuerto_origen = ao.id_aeropuerto
    INNER JOIN dbo.Aeropuertos ad ON v.id_aeropuerto_destino = ad.id_aeropuerto
    INNER JOIN dbo.Aviones av ON v.id_avion = av.id_avion
    INNER JOIN dbo.Est_Vuelo ev ON v.id_est_vuelo = ev.id_est_vuelo
    INNER JOIN dbo.Puerta_Abordaje pa ON v.id_puerta = pa.id_puerta
    WHERE v.numero_vuelo LIKE '%' + @criterio + '%'
       OR ao.nombre LIKE '%' + @criterio + '%'
       OR ad.nombre LIKE '%' + @criterio + '%'
       OR ao.codigo_iata LIKE '%' + @criterio + '%'
       OR ad.codigo_iata LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND v.id_vuelo = TRY_CAST(@criterio AS INT));
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarDestinos
AS
BEGIN
    SELECT 
        v.id_vuelo,
        ad.nombre + ' (' + cd.nombre_ciudad + ')' AS Destino,
        ao.codigo_iata + ' -> ' + ad.codigo_iata AS RutasDisponible,
        CONVERT(VARCHAR(16), v.fecha_salida, 120) AS HoraVuelo,
        v.numero_vuelo,
        v.id_aeropuerto_origen,
        v.id_aeropuerto_destino,
        v.fecha_salida,
        v.fecha_llegada
    FROM dbo.Vuelos v
    INNER JOIN dbo.Aeropuertos ao ON v.id_aeropuerto_origen = ao.id_aeropuerto
    INNER JOIN dbo.Aeropuertos ad ON v.id_aeropuerto_destino = ad.id_aeropuerto
    INNER JOIN dbo.Cuidades cd ON ad.id_ciudad = cd.id_ciudad;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_BuscarDestinos
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT 
        v.id_vuelo,
        ad.nombre + ' (' + cd.nombre_ciudad + ')' AS Destino,
        ao.codigo_iata + ' -> ' + ad.codigo_iata AS RutasDisponible,
        CONVERT(VARCHAR(16), v.fecha_salida, 120) AS HoraVuelo,
        v.numero_vuelo,
        v.id_aeropuerto_origen,
        v.id_aeropuerto_destino,
        v.fecha_salida,
        v.fecha_llegada
    FROM dbo.Vuelos v
    INNER JOIN dbo.Aeropuertos ao ON v.id_aeropuerto_origen = ao.id_aeropuerto
    INNER JOIN dbo.Aeropuertos ad ON v.id_aeropuerto_destino = ad.id_aeropuerto
    INNER JOIN dbo.Cuidades cd ON ad.id_ciudad = cd.id_ciudad
    WHERE ad.nombre LIKE '%' + @criterio + '%'
       OR cd.nombre_ciudad LIKE '%' + @criterio + '%'
       OR ao.codigo_iata LIKE '%' + @criterio + '%'
       OR ad.codigo_iata LIKE '%' + @criterio + '%'
       OR v.numero_vuelo LIKE '%' + @criterio + '%';
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarPaises
AS
BEGIN
    SELECT id_pais, nombre_pais FROM dbo.Paises ORDER BY nombre_pais;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarMetPagos
AS
BEGIN
    SELECT id_met_pago, descripcion FROM dbo.Met_Pagos;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarPagosDetalle
AS
BEGIN
    SELECT 
        p.id_pago,
        p.fecha_pago,
        p.monto,
        p.id_reserva,
        mp.descripcion AS MetodoPago,
        ep.descripcion AS EstadoPago,
        c.nombre + ' ' + c.apellido AS Cliente
    FROM dbo.Pagos p
    INNER JOIN dbo.Met_Pagos mp ON p.id_met_pago = mp.id_met_pago
    INNER JOIN dbo.Est_Pagos ep ON p.id_est_pago = ep.id_est_pago
    LEFT JOIN dbo.Reservas r ON p.id_reserva = r.id_reserva
    LEFT JOIN dbo.Clientes c ON r.id_cliente = c.id_cliente;
END;
GO

CREATE OR ALTER PROCEDURE dbo.SP_ListarClase
AS
BEGIN
    SELECT id_clase, descripcion FROM dbo.Clases ORDER BY id_clase;
END;
GO


