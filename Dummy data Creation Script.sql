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

INSERT INTO empleado([cedula],[nombre],[apellido],[ubicacion],[telefono],[fechanacimiento]) VALUES('1605112846899','Cole','Cole','Apdo.:637-351 Sem Av.','978-1895','07/18/1990'),('1603042678799','Josiah','Goodman','Apdo.:504-5803 Ridiculus Ctra.','1-497-557-4718','07/11/1997'),('1658080650899','Edward','Gill','8428 Porttitor Calle','1-226-175-6581','02/11/1993'),('1638013089499','Bruno','Salas','Apdo.:853-9561 Ultrices. Avda.','1-960-982-1723','07/24/1988'),('1617101623499','Yasir','Hill','262-7120 Risus. Avda.','1-461-456-6943','12/30/1994'),('1690100988399','Katell','Spencer','8322 Luctus. Ctra.','385-9926','08/02/1998'),('1611052171199','Stone','Velez','Apartado núm.: 930, 7154 Ante. ','1-807-294-4047','04/07/1989'),('1630012135299','Adele','Cobb','373-7596 Eu ','297-1075','07/07/1991'),('1634040158699','Whitney','Mccullough','Apartado núm.: 335, 4141 Ac Av.','1-701-333-1990','03/19/1990'),('1660100469599','Kevin','Mueller','Apdo.:429-8448 Sollicitudin Ctra.','1-601-462-8376','01/28/1988');
INSERT INTO empleado([cedula],[nombre],[apellido],[ubicacion],[telefono],[fechanacimiento]) VALUES('1621111878899','Price','Webster','5383 Massa Av.','1-759-997-1951','02/26/1991'),('1627102879599','Helen','Farrell','Apdo.:855-6926 Metus Avda.','1-244-668-0308','09/26/1998'),('1641121608699','Hilel','Franklin','9452 Porta Avda.','568-0209','04/10/2000'),('1664081425499','Acton','Porter','715-9428 In Calle','366-8094','05/09/1995'),('1622121762999','Talon','Kirk','Apdo.:220-1046 Ipsum. Av.','1-401-524-2505','01/08/1992'),('1694012759799','Paki','Cooley','214-3799 Sagittis Avda.','307-5726','05/22/1996'),('1695111538499','Hayfa','Campos','Apartado núm.: 355, 3354 Nulla C/','1-277-474-7936','05/01/1996'),('1699112339399','Abraham','Faulkner','259-5908 Tincidunt Avenida','1-530-576-5711','05/15/1993'),('1662010415399','Oliver','Pollard','699-3417 Luctus ','1-535-281-6877','01/10/1990'),('1662082481399','Veda','Page','387-2637 Tristique ','1-418-733-7937','06/02/1989');
INSERT INTO empleado([cedula],[nombre],[apellido],[ubicacion],[telefono],[fechanacimiento]) VALUES('1626042596299','Blaze','Gutierrez','Apdo.:942-7311 Commodo Calle','452-5468','12/21/1994'),('1698101356999','Jane','Mcfarland','362-5070 Aliquet, Avenida','801-3684','01/07/2003'),('1619011051199','Kenneth','Harrington','Apartado núm.: 129, 2423 Dapibus Ctra.','1-508-778-9789','04/09/1990'),('1609112689099','Laura','Pate','8027 Lorem. C.','483-3483','09/08/1994'),('1675091092599','Kitra','Bauer','Apdo.:807-2571 Vel Calle','1-547-417-0702','10/01/1988'),('1618081302599','Harriet','Boyd','Apdo.:179-6771 Dui, Ctra.','657-9722','03/20/1992'),('1647060706199','Boris','Hopper','2047 Fermentum C/','951-2727','01/18/1989'),('1694031761699','Gary','Merritt','565-4619 Posuere ','1-338-824-5115','11/22/1987'),('1656112350299','Genevieve','Lester','7027 Mauris Av.','1-819-371-5048','12/20/2002'),('1631122557599','Anika','Washington','Apartado núm.: 436, 8959 Mauris. C/','1-717-801-2687','07/24/2000');
INSERT INTO empleado([cedula],[nombre],[apellido],[ubicacion],[telefono],[fechanacimiento]) VALUES('1644070200199','Amity','Mccarty','Apdo.:480-4981 Et, Ctra.','694-6912','08/14/2002'),('1647061705599','Jameson','Crosby','853-4680 Dui Carretera','209-5420','03/30/1994'),('1623032006699','Philip','Romero','Apartado núm.: 481, 5229 Curabitur C.','1-170-314-7233','06/24/1992'),('1653091765099','Blair','Merritt','Apdo.:137-7641 Ac Av.','271-9487','04/27/1996'),('1607112247899','Lani','Lyons','Apartado núm.: 159, 8522 Tortor, ','1-965-747-5946','09/20/1998'),('1641060309699','Keefe','Russell','Apdo.:786-4879 Consequat, Avenida','1-380-589-4264','05/31/1994'),('1635101476199','Madison','Landry','771-2037 Convallis C/','389-2990','07/09/1995'),('1678082851999','Amethyst','Sharpe','Apdo.:247-4359 Vel Avenida','962-9335','08/04/2002'),('1678021237999','Meredith','Richard','Apdo.:811-6710 Nulla. C/','983-7771','12/15/2001'),('1612102608299','Yoshi','Tucker','4115 Vulputate, Avenida','1-297-111-3372','01/10/1997');