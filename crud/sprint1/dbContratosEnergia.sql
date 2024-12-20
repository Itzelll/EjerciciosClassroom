create database ContratosEnergia
go
use ContratosEnergia
go
create table GruposComerciales (
	id int primary key identity,
	nombre varchar(200),
	direccion nvarchar(500),
	RFC nvarchar(13),
	telefono nvarchar(10),
	email nvarchar(100)
);
go

insert into GruposComerciales (nombre, direccion, RFC, telefono, email) values 
('Grupo Soriana', 'Av. Principal #123, Monterrey, NL, M�xico', 'SOR123456ABC', '8112345678', 'contacto@soriana.com'),
('Grupo Walmart', 'Blvd. Industrial #456, Ciudad de M�xico, CDMX, M�xico', 'WAL987654XYZ', '5512345678', 'info@walmart.com'),
('Grupo Chedraui', 'Calle Central #789, Veracruz, VER, M�xico', 'CHE456789DEF', '2291234567', 'servicio@chedraui.com'),
('Grupo Liverpool', 'Av. Insurgentes Sur #101, Ciudad de M�xico, CDMX, M�xico', 'LIV321654GHI', '5543218765', 'contacto@liverpool.com.mx'),
('Grupo La Comer', 'Av. Revoluci�n #202, Guadalajara, JAL, M�xico', 'COM852963JKL', '3312345678', 'info@lacomer.com');

create table Clientes (
	id int primary key identity,
	grupo int,
	nombre varchar(200),
	direccion nvarchar(500),
	telefono nvarchar(10),
	email nvarchar(100),
	foreign key (grupo) references GruposComerciales(id)
);

go
insert into Clientes (grupo, nombre, direccion, telefono, email) values
(1, 'Soriana Monterrey', 'Av. Monterrey #1000, Monterrey, NL, M�xico', '8112345670', 'monterrey@soriana.com'),
(2, 'Walmart Ciudad de M�xico', 'Av. Reforma #500, Ciudad de M�xico, CDMX, M�xico', '5534567890', 'cdmx@walmart.com'),
(3, 'Chedraui Veracruz', 'Calle Veracruz #700, Veracruz, VER, M�xico', '2298765432', 'veracruz@chedraui.com'),
(4, 'Liverpool Insurgentes', 'Av. Insurgentes #120, Ciudad de M�xico, CDMX, M�xico', '5549876543', 'insurgentes@liverpool.com.mx'),
(5, 'La Comer Guadalajara', 'Av. Revoluci�n #150, Guadalajara, JAL, M�xico', '3319876543', 'guadalajara@lacomer.com');

create table TiposContratos(
	id int primary key identity,
	descripcion nvarchar(500)
);

create table Contratos (
	id int primary key identity,
	cliente int,
	tipoContrato int,
	fechaInicio datetime,
	fechaFinal datetime,
	monto decimal(18,2),
	descripcion nvarchar(200),
	foreign key (cliente) references Clientes(id),
	foreign key (tipoContrato) references TiposContratos(id)
);

drop table Contratos

INSERT INTO TiposContratos (descripcion) VALUES
('Concesi�n para CFE'),
('Auto-abasto'),
('Mercado El�ctrico Mayorista'),
('Contrato de Generaci�n Privada'),
('Contrato Comercial para Suministro Directo');

INSERT INTO Contratos (cliente, tipoContrato, fechaInicio, fechaFinal, monto, descripcion) VALUES
(1, 1, '2024-01-01', '2025-01-01', 5000000, 'Contrato de concesi�n con CFE para suministro de energ�a'),
(2, 2, '2024-03-01', '2027-03-01', 15000000, 'Contrato de auto-abasto para Walmart Ciudad de M�xico'),
(3, 3, '2024-06-01', '2026-06-01', 8000000, 'Contrato de participaci�n en el Mercado El�ctrico Mayorista'),
(4, 4, '2024-05-01', '2029-05-01', 12000000, 'Contrato de Generaci�n Privada con suministro propio'),
(5, 5, '2024-07-01', '2027-07-01', 6000000, 'Contrato de suministro el�ctrico directo para La Comer Guadalajara');

