CREATE DATABASE EMPLEADOBD
GO;
CREATE TABLE PERSONA (
IDPERSONA INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPERSONA),
);
CREATE TABLE USUARIO (
IDEMPLEADO INT IDENTITY (1,1) NOT NULL,
IDPERSONA INT NOT NULL,
PUESTO NVARCHAR (50) NOT NULL,
SALARIO MONEY NOT NULL,
FECHACONTRATACION DATETIME NOT NULL,
PRIMARY KEY (IDEMPLEADO),
FOREIGN KEY (IDPERSONA) REFERENCES PERSONA (IDPERSONA)
);