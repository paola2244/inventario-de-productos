# Sistema de Inventario y Facturación

Aplicación de escritorio para la gestión integral de inventario, productos, ventas y caja de una tienda o negocio. Desarrollada en C# con Windows Forms siguiendo el patrón MVC.

---

## Tabla de Contenidos

- [Descripción](#descripción)
- [Tecnologías](#tecnologías)
- [Arquitectura](#arquitectura)
- [Requisitos](#requisitos)
- [Instalación y Configuración](#instalación-y-configuración)
- [Base de Datos](#base-de-datos)
- [Módulos del Sistema](#módulos-del-sistema)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Contribuidores](#contribuidores)

---

## Descripción

Sistema de gestión diseñado para negocios que necesitan controlar su inventario, registrar ventas y administrar su personal. Cuenta con dos perfiles de acceso: **Administrador** y **Bodeguero**, cada uno con vistas y permisos diferenciados.

---

## Tecnologías

| Componente | Tecnología |
|---|---|
| Lenguaje | C# |
| Framework | .NET 8.0 |
| Interfaz gráfica | Windows Forms (WinForms) |
| Base de datos | SQL Server Express |
| Driver de datos | Microsoft.Data.SqlClient v6.1.1 |
| IDE recomendado | Visual Studio 2022 |
| Control de versiones | Git |

---

## Arquitectura

El proyecto sigue el patrón **MVC (Model-View-Controller)**:

```
Vista (Windows Forms)
       │
       ▼
Controller (lógica de negocio)
       │
       ▼
Model (entidades + conexión BD)
       │
       ▼
SQL Server Express
```

- **Model/** — Entidades del dominio y gestión de la conexión a la base de datos.
- **Controller/** — Lógica de negocio, consultas y operaciones CRUD.
- **vista/** — Formularios Windows Forms para cada módulo de la aplicación.

---

## Requisitos

- Windows 10 / 11
- .NET 8.0 Runtime
- SQL Server Express (instancia `SQLEXPRESS`)
- Visual Studio 2022 (para desarrollo)

---

## Instalación y Configuración

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/paola2244/inventario-de-productos.git
   cd inventario-de-productos
   ```

2. **Restaurar la base de datos**

   Abrir SQL Server Management Studio (SSMS) y ejecutar el script:
   ```
   Base de datos Inventario.sql
   ```
   Esto creará la base de datos `INVENTARIO` con todas sus tablas y relaciones.

3. **Configurar la cadena de conexión**

   En `InventarioFacturacion/Model/ConexionBD.cs`, verificar que el servidor coincida con tu instancia local:
   ```csharp
   // Ajustar según el nombre de tu instancia de SQL Server
   Server=TU-PC\SQLEXPRESS;Database=INVENTARIO;...
   ```

4. **Compilar y ejecutar**

   Abrir `InventarioFacturacion.sln` en Visual Studio 2022 y presionar `F5`, o compilar desde terminal:
   ```bash
   dotnet build
   dotnet run
   ```

---

## Base de Datos

El script `Base de datos Inventario.sql` crea la base de datos `INVENTARIO` con las siguientes tablas:

| Tabla | Descripción |
|---|---|
| `cargo` | Roles y cargos del personal |
| `persona` | Datos de empleados |
| `Credenciales` | Usuarios y contraseñas para autenticación |
| `Caja` | Control de las cajas registradoras |
| `Turnos` | Jornadas laborales por empleado y caja |
| `TipoCategoria` | Categorías de productos |
| `Producto` | Catálogo de productos con precios y stock |
| `INVENTARIO` | Control de existencias |
| `Factura` | Encabezado de ventas |
| `DetalleFactura` | Líneas de detalle por factura |

---

## Módulos del Sistema

### Autenticación
- Login con validación de credenciales por rol.
- Redirige al panel de **Administrador** o **Bodeguero** según el cargo del usuario.

### Gestión de Empleados
- CRUD completo: registrar, consultar, editar y eliminar empleados.
- Datos: cédula, nombre, apellido, teléfono, correo, dirección, ciudad y cargo.

### Gestión de Cargos
- Administración de los roles disponibles en el sistema.

### Categorías de Productos
- CRUD de categorías para clasificar el inventario.

### Inventario y Productos
- Registro de productos con nombre, categoría, precios, unidad de medida y cantidad en stock.
- Control de disponibilidad en bodega.

### Caja
- Gestión de hasta 3 cajas.
- Registro de monto inicial, ventas en efectivo, ventas online, monto final y diferencias.

### Ventas y Facturación
- Creación de facturas con detalle de productos, cantidades, precios unitarios, subtotales y descuentos.
- Registro automático de fecha y hora de venta.

### Turnos
- Asignación de empleados a cajas por período de trabajo (fecha y hora de inicio/fin).

### Reportes
- Módulo en desarrollo.

---

## Estructura del Proyecto

```
Inventario-de-Productos/
├── InventarioFacturacion/
│   ├── Controller/
│   │   ├── CajaController.cs
│   │   ├── CargoController.cs
│   │   ├── CategoriaController.cs
│   │   ├── LoginController.cs
│   │   └── PersonaController.cs
│   ├── Model/
│   │   ├── Caja.cs
│   │   ├── Cargo.cs
│   │   ├── Categoria.cs
│   │   ├── ConexionBD.cs
│   │   ├── Credencial.cs
│   │   └── Persona.cs
│   ├── vista/
│   │   ├── CajasVistas.cs
│   │   ├── CobrarVista.cs
│   │   ├── DetalleFacturaVista.cs
│   │   ├── PrincipalAdministrador.cs
│   │   ├── PrincipalBodegueroVista.cs
│   │   ├── PrincipalVista.cs
│   │   ├── ProductoVista.cs
│   │   ├── ReporteVista.cs
│   │   ├── TablaInventarioVista.cs
│   │   ├── TurnosVista.cs
│   │   ├── VentasVista.cs
│   │   ├── Cliente/
│   │   │   └── RegistrarClienteVista.cs
│   │   ├── RegistrarEmpleado/
│   │   │   └── RegistrarEmpleadoVista.cs
│   │   └── VistaCategoria/
│   │       └── CategoriaVista.cs
│   ├── Resources/
│   ├── Program.cs
│   └── InventarioFacturacion.csproj
├── Base de datos Inventario.sql
└── InventarioFacturacion.sln
```

---

## Contribuidores

| Nombre | Rol |
|---|---|
| Paola (Lina) | Desarrolladora |
| Andrés | Desarrollador |

---

> Proyecto en desarrollo — versión 0.1.1
