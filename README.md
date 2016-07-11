# TAREA 5

<p align="center">
 <img src="https://github.com/fluidicon.png" width="60">
</p>

###Tarea 5

###Rolando Esp

Registro de Empleados a la Base de Datos

##Notas: tener la DB como LOCAL


```sql
USE [bd_empresa]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 07/10/2016 17:56:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[cedula] [bigint] NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[ubicacion] [nvarchar](250) NULL,
	[telefono] [nvarchar](50) NULL,
	[fechanacimiento] [nchar](10) NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
```
