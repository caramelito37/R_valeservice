CREATE DATABASE IF NOT EXISTS db_valeservice;

USE db_valeservice;

CREATE TABLE Cliente (
    Cliente_DNI INT PRIMARY KEY NOT NULL,
    Cliente_Nombre_Apellido VARCHAR(100) NOT NULL,
    Cliente_Contacto INT NOT NULL
);

CREATE TABLE Vehiculo (
    Vehiculo_Placa VARCHAR(7) PRIMARY KEY NOT NULL,
    Vehiculo_Marca VARCHAR(50) NOT NULL,
    Vehiculo_Modelo VARCHAR(50) NOT NULL,
    Vehiculo_Año DATE NOT NULL,
    Vehiculo_Kilometraje INT NOT NULL
);

CREATE TABLE RecepcionVehiculo (
	RecepcionVehiculo_Id INT PRIMARY KEY auto_increment NOT NULL,
    RecepcionVehiculo_Fecha_Entrada DATE NOT NULL,
    RecepcionVehiculo_Fecha_Salida DATE,
    RecepcionVehiculo_Cuenta DECIMAL(10, 2) NOT NULL,
    Vehiculo_Placa VARCHAR(7) NOT NULL,
	Cliente_DNI INT NOT NULL,
    FOREIGN KEY (Cliente_DNI) REFERENCES Cliente(Cliente_DNI),
    FOREIGN KEY (Vehiculo_Placa)REFERENCES Vehiculo(Vehiculo_Placa)
);

CREATE TABLE Hoja (
    Hoja_Numero INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    Hoja_fecha TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
	RecepcionVehiculo_Id INT,    
    Carros_Placa VARCHAR(7) NOT NULL,
    
	FOREIGN KEY (RecepcionVehiculo_Id) REFERENCES RecepcionVehiculo(RecepcionVehiculo_Id)
);

CREATE TABLE ServiciosMecanicos (     
    ServiciosMecanicos_Id INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
    ServiciosMecanicos_Descripcion VARCHAR(100) NOT NULL
);

CREATE TABLE ManoDeObra (
    ManoDeObra_Cantidad INT NOT NULL,
    ManoDeObra_Descripcion VARCHAR(100) NOT NULL,
    ManoDeObra_Costo DECIMAL(10, 2) NOT NULL,
    ManoDeObra_Tiempo TIME NOT NULL,
    ServiciosMecanicos_Id INT NOT NULL,
    Hoja_Numero INT not null,
	FOREIGN KEY (Hoja_Numero) REFERENCES Hoja(Hoja_Numero),
    FOREIGN KEY (ServiciosMecanicos_Id) REFERENCES ServiciosMecanicos(ServiciosMecanicos_Id)
);

CREATE TABLE Repuesto (
    Repuesto_Id INT PRIMARY KEY NOT NULL,
    Repuesto_Descripcion VARCHAR(10) NOT NULL
);

CREATE TABLE Hoja_Repuestos (
    Hoja_Repuestos_Cantidad INT NOT NULL,
    Hoja_Repuestos_Descripcion VARCHAR(100) NOT NULL,
    Hoja_Repuestos_Costo DECIMAL(10, 2) NOT NULL,
    Hoja_Repuestos_Marca VARCHAR(10) NOT NULL,
    Repuesto_Id INT NOT NULL,
    Hoja_Numero INT NOT NULL,
    FOREIGN KEY (Repuesto_Id) REFERENCES Repuesto(Repuesto_Id),
    FOREIGN KEY (Hoja_Numero) REFERENCES Hoja(Hoja_Numero)
);

CREATE TABLE Usuarios (
    NombreUsuario VARCHAR(50) PRIMARY KEY NOT NULL,
    Contraseña VARCHAR(50) NOT NULL,
    Rol ENUM('Administrador', 'Usuario') NOT NULL
);

INSERT INTO Usuarios (NombreUsuario, Contraseña, Rol) VALUES
('admin', 'admin', 'Administrador'),
('user', 'user', 'Usuario');

INSERT INTO Cliente (Cliente_DNI, Cliente_Nombre_Apellido, Cliente_Contacto)
VALUES
    (123456789, 'Juan Pérez', 555123456),
    (987654321, 'María García', 555987654),
    (456789123, 'Carlos López', 555234567),
    (789123456, 'Ana Martínez', 555876543),
    (321654987, 'Pedro Rodríguez', 555345678);
    
INSERT INTO Vehiculo (Vehiculo_Placa, Vehiculo_Marca, Vehiculo_Modelo, Vehiculo_Año, Vehiculo_Kilometraje)
VALUES 
('ABC1234', 'Toyota', 'Corolla', 2012, 50000),
('DEF5678', 'Honda', 'Civic', 2014, 70000),
('GHI9101', 'Ford', 'Mustang', 2016, 30000),
('JKL1122', 'Chevrolet', 'Camaro', 2018, 60000);
