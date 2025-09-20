
select * from cargo


CREATE TABLE cargo (
    id_cargo INT PRIMARY KEY IDENTITY,
    nombrecargo NVARCHAR(100)
);

CREATE TABLE persona (
	IDPERSONA INT PRIMARY KEY IDENTITY,
    CC INT,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Dirección NVARCHAR(150),
    Ciudad NVARCHAR(100),
    id_cargo INT,
    FOREIGN KEY (id_cargo) REFERENCES cargo(id_cargo)
);

CREATE TABLE Credenciales (
    IdCredencial INT PRIMARY KEY IDENTITY,
    Usuario NVARCHAR(50),
    Contraseña NVARCHAR(100),
    IDPERSONA INT,
    FOREIGN KEY (IDPERSONA) REFERENCES persona(IDPERSONA)
);

CREATE TABLE Caja (
    IdCaja INT PRIMARY KEY,
    MontoInicial DECIMAL(10,2),
    MontoFinal DECIMAL(10,2),
    TotalVentasEfectivo DECIMAL(10,2),
    TotalVentasOnline DECIMAL(10,2),
    TotalCaja DECIMAL(10,2),
    Diferencia DECIMAL(10,2)
);

CREATE TABLE Turnos (
    IdTurnos INT PRIMARY KEY IDENTITY,
    IDCREDENCIAL INT,
    IdCaja INT,
    FechaInicial DATE,
    FechaFinal DATE,
    HoraInicial TIME,
    HoraFinal TIME,
    FOREIGN KEY (IDCREDENCIAL) REFERENCES Credenciales(IdCredencial),
    FOREIGN KEY (IdCaja) REFERENCES Caja(IdCaja)
);

CREATE TABLE TipoCategoria (
    IdTipoCategoria INT PRIMARY KEY IDENTITY,
    NombreCategoria NVARCHAR(100)
);

CREATE TABLE Producto (
    IdProducto INT PRIMARY KEY IDENTITY,
    IdTipoCategoria INT,
    NombreProducto NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(100),
    Precio1 DECIMAL(10,2),
    PrecioOpcional DECIMAL(10,2),
    UnidadDeMedida NVARCHAR(50),
    Cantidad INT,
    DisponibleEnBodega BIT,
    FOREIGN KEY (IdTipoCategoria) REFERENCES TipoCategoria(IdTipoCategoria)
);

CREATE TABLE INVENTARIO (
    ID_INVENTARIO INT PRIMARY KEY,
    cantidad_de_productos INT,
    descripcion NVARCHAR(255),
    Activo BIT,
    id_producto INT,
    FOREIGN KEY (id_producto) REFERENCES Producto(IdProducto)
);

CREATE TABLE Factura (
    IdFactura INT PRIMARY KEY IDENTITY,
    idcredencial INT,
    Fecha DATE,
    HoraVenta TIME,
    Descuento DECIMAL(10,2),
    Total DECIMAL(10,2),
    FOREIGN KEY (idcredencial) REFERENCES Credenciales(IdCredencial)
);

CREATE TABLE DetalleFactura (
    IdDetalle INT PRIMARY KEY IDENTITY,
    IdProducto INT,
    IdFactura INT,
    NombreProducto NVARCHAR(100),
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2),
    Subtotal DECIMAL(10,2),
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto),
    FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura)
);
