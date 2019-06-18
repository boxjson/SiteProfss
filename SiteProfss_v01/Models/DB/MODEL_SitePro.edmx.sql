
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/13/2016 01:36:34
-- Generated from EDMX file: C:\Users\bryga\Desktop\JUDC[FINAL]]_SiteProfs_v01\SiteProfss_v01\SiteProfss_v01\Models\DB\MODEL_SitePro.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_SiteProfss];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AnioAcademicoSolicitante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Solicitante] DROP CONSTRAINT [FK_AnioAcademicoSolicitante];
GO
IF OBJECT_ID(N'[dbo].[FK_AptitudAptitudRequerida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AptitudesRequeridas] DROP CONSTRAINT [FK_AptitudAptitudRequerida];
GO
IF OBJECT_ID(N'[dbo].[FK_AptitudSolicitanteAptitud]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitantesAptitudes] DROP CONSTRAINT [FK_AptitudSolicitanteAptitud];
GO
IF OBJECT_ID(N'[dbo].[FK_CarreraSolicitante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Solicitante] DROP CONSTRAINT [FK_CarreraSolicitante];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaAlerta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alertas] DROP CONSTRAINT [FK_CategoriaAlerta];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaEmpresaCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpresasCategorias] DROP CONSTRAINT [FK_CategoriaEmpresaCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaOferta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ofertas] DROP CONSTRAINT [FK_CategoriaOferta];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartamentoAlerta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alertas] DROP CONSTRAINT [FK_DepartamentoAlerta];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartamentoMunicipio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Municipios] DROP CONSTRAINT [FK_DepartamentoMunicipio];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartamentoOferta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ofertas] DROP CONSTRAINT [FK_DepartamentoOferta];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartamentoUCarrera]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carreras] DROP CONSTRAINT [FK_DepartamentoUCarrera];
GO
IF OBJECT_ID(N'[dbo].[FK_Empresa_inherits_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Empresa] DROP CONSTRAINT [FK_Empresa_inherits_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpresaEmpresaCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmpresasCategorias] DROP CONSTRAINT [FK_EmpresaEmpresaCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpresaOferta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ofertas] DROP CONSTRAINT [FK_EmpresaOferta];
GO
IF OBJECT_ID(N'[dbo].[FK_FacultadDepartamentoU]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartamentosU] DROP CONSTRAINT [FK_FacultadDepartamentoU];
GO
IF OBJECT_ID(N'[dbo].[FK_MunicipioUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK_MunicipioUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_NivelAptitudRequerida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AptitudesRequeridas] DROP CONSTRAINT [FK_NivelAptitudRequerida];
GO
IF OBJECT_ID(N'[dbo].[FK_NivelSolicitanteAptitud]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitantesAptitudes] DROP CONSTRAINT [FK_NivelSolicitanteAptitud];
GO
IF OBJECT_ID(N'[dbo].[FK_OfertaAptitudRequerida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AptitudesRequeridas] DROP CONSTRAINT [FK_OfertaAptitudRequerida];
GO
IF OBJECT_ID(N'[dbo].[FK_OfertaSolicitud]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_OfertaSolicitud];
GO
IF OBJECT_ID(N'[dbo].[FK_OfertaVisita]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Visitas] DROP CONSTRAINT [FK_OfertaVisita];
GO
IF OBJECT_ID(N'[dbo].[FK_SexoSolicitante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Solicitante] DROP CONSTRAINT [FK_SexoSolicitante];
GO
IF OBJECT_ID(N'[dbo].[FK_Solicitante_inherits_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuarios_Solicitante] DROP CONSTRAINT [FK_Solicitante_inherits_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_SolicitanteAlerta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alertas] DROP CONSTRAINT [FK_SolicitanteAlerta];
GO
IF OBJECT_ID(N'[dbo].[FK_SolicitanteSolicitanteAptitud]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitantesAptitudes] DROP CONSTRAINT [FK_SolicitanteSolicitanteAptitud];
GO
IF OBJECT_ID(N'[dbo].[FK_SolicitanteSolicitud]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Solicitudes] DROP CONSTRAINT [FK_SolicitanteSolicitud];
GO
IF OBJECT_ID(N'[dbo].[FK_TiempoContratacionOferta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ofertas] DROP CONSTRAINT [FK_TiempoContratacionOferta];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversidadFacultad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facultades] DROP CONSTRAINT [FK_UniversidadFacultad];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Alertas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alertas];
GO
IF OBJECT_ID(N'[dbo].[AniosAcademicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AniosAcademicos];
GO
IF OBJECT_ID(N'[dbo].[Aptitudes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aptitudes];
GO
IF OBJECT_ID(N'[dbo].[AptitudesRequeridas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AptitudesRequeridas];
GO
IF OBJECT_ID(N'[dbo].[Carreras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carreras];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Departamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departamentos];
GO
IF OBJECT_ID(N'[dbo].[DepartamentosU]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartamentosU];
GO
IF OBJECT_ID(N'[dbo].[EmpresasCategorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpresasCategorias];
GO
IF OBJECT_ID(N'[dbo].[Facultades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facultades];
GO
IF OBJECT_ID(N'[dbo].[Municipios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Municipios];
GO
IF OBJECT_ID(N'[dbo].[Niveles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Niveles];
GO
IF OBJECT_ID(N'[dbo].[Ofertas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ofertas];
GO
IF OBJECT_ID(N'[dbo].[Sexos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sexos];
GO
IF OBJECT_ID(N'[dbo].[SolicitantesAptitudes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SolicitantesAptitudes];
GO
IF OBJECT_ID(N'[dbo].[Solicitudes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Solicitudes];
GO
IF OBJECT_ID(N'[dbo].[TiemposContratacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TiemposContratacion];
GO
IF OBJECT_ID(N'[dbo].[Universidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Universidades];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Usuarios_Empresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios_Empresa];
GO
IF OBJECT_ID(N'[dbo].[Usuarios_Solicitante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios_Solicitante];
GO
IF OBJECT_ID(N'[dbo].[Visitas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Visitas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL,
    [Foto] varbinary(max)  NULL,
    [Direccion] nvarchar(200)  NULL,
    [SitioWeb] nvarchar(100)  NULL,
    [DireccionFacebook] nvarchar(100)  NULL,
    [MunicipioId] int  NULL
);
GO

-- Creating table 'Departamentos'
CREATE TABLE [dbo].[Departamentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreDepartamento] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Municipios'
CREATE TABLE [dbo].[Municipios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreMunicipio] nvarchar(50)  NOT NULL,
    [DepartamentoId] int  NOT NULL
);
GO

-- Creating table 'Universidades'
CREATE TABLE [dbo].[Universidades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreUniversidad] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Facultades'
CREATE TABLE [dbo].[Facultades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreFacultad] nvarchar(50)  NOT NULL,
    [UniversidadId] int  NOT NULL
);
GO

-- Creating table 'DepartamentosU'
CREATE TABLE [dbo].[DepartamentosU] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreDepartamento] nvarchar(50)  NOT NULL,
    [FacultadId] int  NOT NULL
);
GO

-- Creating table 'Carreras'
CREATE TABLE [dbo].[Carreras] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreCarrera] nvarchar(50)  NOT NULL,
    [DepartamentoUId] int  NOT NULL
);
GO

-- Creating table 'Sexos'
CREATE TABLE [dbo].[Sexos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [Descripcion] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'AniosAcademicos'
CREATE TABLE [dbo].[AniosAcademicos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [Descripcion] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'Visitas'
CREATE TABLE [dbo].[Visitas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaVisita] datetime  NOT NULL,
    [OfertaId] int  NOT NULL,
    [OfertaId1] int  NOT NULL
);
GO

-- Creating table 'TiemposContratacion'
CREATE TABLE [dbo].[TiemposContratacion] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [Descripcion] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Solicitudes'
CREATE TABLE [dbo].[Solicitudes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaSolicitud] datetime  NOT NULL,
    [ComentariosSolicitante] nvarchar(100)  NOT NULL,
    [ComentariosEmpresa] nvarchar(100)  NOT NULL,
    [VistaEmpresa] bit  NOT NULL,
    [FechaVista] datetime  NULL,
    [SolicitanteId] int  NOT NULL,
    [OfertaId] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [NombreCategoria] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'EmpresasCategorias'
CREATE TABLE [dbo].[EmpresasCategorias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmpresaId] int  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Aptitudes'
CREATE TABLE [dbo].[Aptitudes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [Descripcion] nvarchar(50)  NOT NULL,
    [Tipo] nvarchar(1)  NOT NULL
);
GO

-- Creating table 'SolicitantesAptitudes'
CREATE TABLE [dbo].[SolicitantesAptitudes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SolicitanteId] int  NOT NULL,
    [AptitudId] int  NOT NULL,
    [NivelId] int  NOT NULL
);
GO

-- Creating table 'AptitudesRequeridas'
CREATE TABLE [dbo].[AptitudesRequeridas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OfertaId] int  NOT NULL,
    [AptitudId] int  NOT NULL,
    [NivelId] int  NOT NULL,
    [OfertaId1] int  NOT NULL
);
GO

-- Creating table 'Niveles'
CREATE TABLE [dbo].[Niveles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Codigo] nvarchar(10)  NOT NULL,
    [Descripcion] nvarchar(50)  NOT NULL,
    [Tipo] nvarchar(1)  NOT NULL
);
GO

-- Creating table 'Alertas'
CREATE TABLE [dbo].[Alertas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FechaCreacion] datetime  NOT NULL,
    [Parametro] nvarchar(100)  NOT NULL,
    [Activa] bit  NOT NULL,
    [SolicitanteId] int  NOT NULL,
    [CategoriaId] int  NOT NULL,
    [DepartamentoId] int  NOT NULL
);
GO

-- Creating table 'Ofertas'
CREATE TABLE [dbo].[Ofertas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(100)  NOT NULL,
    [Descripcion] nvarchar(250)  NOT NULL,
    [FechaPublicacion] datetime  NOT NULL,
    [AreaLaboral] nvarchar(50)  NOT NULL,
    [CantidadVacantes] int  NOT NULL,
    [HabilidadesRequeridas] nvarchar(250)  NOT NULL,
    [EdadDesde] int  NOT NULL,
    [EdadHasta] int  NOT NULL,
    [Remuneracion] bit  NOT NULL,
    [TransporteRecorrido] bit  NOT NULL,
    [FechaLimiteSolicitud] datetime  NOT NULL,
    [Anulada] bit  NOT NULL,
    [EmpresaId] int  NOT NULL,
    [CategoriaId] int  NOT NULL,
    [DepartamentoId] int  NOT NULL,
    [TiempoContratacionId] int  NOT NULL
);
GO

-- Creating table 'Usuarios_Solicitante'
CREATE TABLE [dbo].[Usuarios_Solicitante] (
    [NumeroCarnet] nvarchar(20)  NULL,
    [NumeroCedula] nvarchar(20)  NOT NULL,
    [Nombres] nvarchar(50)  NOT NULL,
    [Apellidos] nvarchar(50)  NOT NULL,
    [FechaNacimiento] datetime  NOT NULL,
    [Nacionalidad] nvarchar(50)  NULL,
    [Descripcion] nvarchar(50)  NULL,
    [TelefonoCasa] nvarchar(50)  NULL,
    [TelefonoCelular1] nvarchar(20)  NULL,
    [TelefonoCelular2] nvarchar(20)  NULL,
    [CurriculumVitae] varbinary(max)  NULL,
    [CarreraId] int  NULL,
    [SexoId] int  NOT NULL,
    [AnioAcademicoId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Usuarios_Empresa'
CREATE TABLE [dbo].[Usuarios_Empresa] (
    [NombreEmpresa] nvarchar(100)  NOT NULL,
    [Descripcion] nvarchar(100)  NULL,
    [Telefono] nvarchar(20)  NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departamentos'
ALTER TABLE [dbo].[Departamentos]
ADD CONSTRAINT [PK_Departamentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Municipios'
ALTER TABLE [dbo].[Municipios]
ADD CONSTRAINT [PK_Municipios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Universidades'
ALTER TABLE [dbo].[Universidades]
ADD CONSTRAINT [PK_Universidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Facultades'
ALTER TABLE [dbo].[Facultades]
ADD CONSTRAINT [PK_Facultades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepartamentosU'
ALTER TABLE [dbo].[DepartamentosU]
ADD CONSTRAINT [PK_DepartamentosU]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Carreras'
ALTER TABLE [dbo].[Carreras]
ADD CONSTRAINT [PK_Carreras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sexos'
ALTER TABLE [dbo].[Sexos]
ADD CONSTRAINT [PK_Sexos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AniosAcademicos'
ALTER TABLE [dbo].[AniosAcademicos]
ADD CONSTRAINT [PK_AniosAcademicos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Visitas'
ALTER TABLE [dbo].[Visitas]
ADD CONSTRAINT [PK_Visitas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TiemposContratacion'
ALTER TABLE [dbo].[TiemposContratacion]
ADD CONSTRAINT [PK_TiemposContratacion]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [PK_Solicitudes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmpresasCategorias'
ALTER TABLE [dbo].[EmpresasCategorias]
ADD CONSTRAINT [PK_EmpresasCategorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Aptitudes'
ALTER TABLE [dbo].[Aptitudes]
ADD CONSTRAINT [PK_Aptitudes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SolicitantesAptitudes'
ALTER TABLE [dbo].[SolicitantesAptitudes]
ADD CONSTRAINT [PK_SolicitantesAptitudes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AptitudesRequeridas'
ALTER TABLE [dbo].[AptitudesRequeridas]
ADD CONSTRAINT [PK_AptitudesRequeridas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Niveles'
ALTER TABLE [dbo].[Niveles]
ADD CONSTRAINT [PK_Niveles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Alertas'
ALTER TABLE [dbo].[Alertas]
ADD CONSTRAINT [PK_Alertas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ofertas'
ALTER TABLE [dbo].[Ofertas]
ADD CONSTRAINT [PK_Ofertas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios_Solicitante'
ALTER TABLE [dbo].[Usuarios_Solicitante]
ADD CONSTRAINT [PK_Usuarios_Solicitante]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios_Empresa'
ALTER TABLE [dbo].[Usuarios_Empresa]
ADD CONSTRAINT [PK_Usuarios_Empresa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DepartamentoId] in table 'Municipios'
ALTER TABLE [dbo].[Municipios]
ADD CONSTRAINT [FK_DepartamentoMunicipio]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamentos]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoMunicipio'
CREATE INDEX [IX_FK_DepartamentoMunicipio]
ON [dbo].[Municipios]
    ([DepartamentoId]);
GO

-- Creating foreign key on [MunicipioId] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_MunicipioUsuario]
    FOREIGN KEY ([MunicipioId])
    REFERENCES [dbo].[Municipios]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MunicipioUsuario'
CREATE INDEX [IX_FK_MunicipioUsuario]
ON [dbo].[Usuarios]
    ([MunicipioId]);
GO

-- Creating foreign key on [UniversidadId] in table 'Facultades'
ALTER TABLE [dbo].[Facultades]
ADD CONSTRAINT [FK_UniversidadFacultad]
    FOREIGN KEY ([UniversidadId])
    REFERENCES [dbo].[Universidades]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversidadFacultad'
CREATE INDEX [IX_FK_UniversidadFacultad]
ON [dbo].[Facultades]
    ([UniversidadId]);
GO

-- Creating foreign key on [FacultadId] in table 'DepartamentosU'
ALTER TABLE [dbo].[DepartamentosU]
ADD CONSTRAINT [FK_FacultadDepartamentoU]
    FOREIGN KEY ([FacultadId])
    REFERENCES [dbo].[Facultades]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultadDepartamentoU'
CREATE INDEX [IX_FK_FacultadDepartamentoU]
ON [dbo].[DepartamentosU]
    ([FacultadId]);
GO

-- Creating foreign key on [DepartamentoUId] in table 'Carreras'
ALTER TABLE [dbo].[Carreras]
ADD CONSTRAINT [FK_DepartamentoUCarrera]
    FOREIGN KEY ([DepartamentoUId])
    REFERENCES [dbo].[DepartamentosU]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoUCarrera'
CREATE INDEX [IX_FK_DepartamentoUCarrera]
ON [dbo].[Carreras]
    ([DepartamentoUId]);
GO

-- Creating foreign key on [CarreraId] in table 'Usuarios_Solicitante'
ALTER TABLE [dbo].[Usuarios_Solicitante]
ADD CONSTRAINT [FK_CarreraSolicitante]
    FOREIGN KEY ([CarreraId])
    REFERENCES [dbo].[Carreras]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarreraSolicitante'
CREATE INDEX [IX_FK_CarreraSolicitante]
ON [dbo].[Usuarios_Solicitante]
    ([CarreraId]);
GO

-- Creating foreign key on [SexoId] in table 'Usuarios_Solicitante'
ALTER TABLE [dbo].[Usuarios_Solicitante]
ADD CONSTRAINT [FK_SexoSolicitante]
    FOREIGN KEY ([SexoId])
    REFERENCES [dbo].[Sexos]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SexoSolicitante'
CREATE INDEX [IX_FK_SexoSolicitante]
ON [dbo].[Usuarios_Solicitante]
    ([SexoId]);
GO

-- Creating foreign key on [AnioAcademicoId] in table 'Usuarios_Solicitante'
ALTER TABLE [dbo].[Usuarios_Solicitante]
ADD CONSTRAINT [FK_AnioAcademicoSolicitante]
    FOREIGN KEY ([AnioAcademicoId])
    REFERENCES [dbo].[AniosAcademicos]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnioAcademicoSolicitante'
CREATE INDEX [IX_FK_AnioAcademicoSolicitante]
ON [dbo].[Usuarios_Solicitante]
    ([AnioAcademicoId]);
GO

-- Creating foreign key on [SolicitanteId] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_SolicitanteSolicitud]
    FOREIGN KEY ([SolicitanteId])
    REFERENCES [dbo].[Usuarios_Solicitante]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolicitanteSolicitud'
CREATE INDEX [IX_FK_SolicitanteSolicitud]
ON [dbo].[Solicitudes]
    ([SolicitanteId]);
GO

-- Creating foreign key on [EmpresaId] in table 'EmpresasCategorias'
ALTER TABLE [dbo].[EmpresasCategorias]
ADD CONSTRAINT [FK_EmpresaEmpresaCategoria]
    FOREIGN KEY ([EmpresaId])
    REFERENCES [dbo].[Usuarios_Empresa]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaEmpresaCategoria'
CREATE INDEX [IX_FK_EmpresaEmpresaCategoria]
ON [dbo].[EmpresasCategorias]
    ([EmpresaId]);
GO

-- Creating foreign key on [CategoriaId] in table 'EmpresasCategorias'
ALTER TABLE [dbo].[EmpresasCategorias]
ADD CONSTRAINT [FK_CategoriaEmpresaCategoria]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaEmpresaCategoria'
CREATE INDEX [IX_FK_CategoriaEmpresaCategoria]
ON [dbo].[EmpresasCategorias]
    ([CategoriaId]);
GO

-- Creating foreign key on [SolicitanteId] in table 'SolicitantesAptitudes'
ALTER TABLE [dbo].[SolicitantesAptitudes]
ADD CONSTRAINT [FK_SolicitanteSolicitanteAptitud]
    FOREIGN KEY ([SolicitanteId])
    REFERENCES [dbo].[Usuarios_Solicitante]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolicitanteSolicitanteAptitud'
CREATE INDEX [IX_FK_SolicitanteSolicitanteAptitud]
ON [dbo].[SolicitantesAptitudes]
    ([SolicitanteId]);
GO

-- Creating foreign key on [AptitudId] in table 'SolicitantesAptitudes'
ALTER TABLE [dbo].[SolicitantesAptitudes]
ADD CONSTRAINT [FK_AptitudSolicitanteAptitud]
    FOREIGN KEY ([AptitudId])
    REFERENCES [dbo].[Aptitudes]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AptitudSolicitanteAptitud'
CREATE INDEX [IX_FK_AptitudSolicitanteAptitud]
ON [dbo].[SolicitantesAptitudes]
    ([AptitudId]);
GO

-- Creating foreign key on [AptitudId] in table 'AptitudesRequeridas'
ALTER TABLE [dbo].[AptitudesRequeridas]
ADD CONSTRAINT [FK_AptitudAptitudRequerida]
    FOREIGN KEY ([AptitudId])
    REFERENCES [dbo].[Aptitudes]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AptitudAptitudRequerida'
CREATE INDEX [IX_FK_AptitudAptitudRequerida]
ON [dbo].[AptitudesRequeridas]
    ([AptitudId]);
GO

-- Creating foreign key on [NivelId] in table 'SolicitantesAptitudes'
ALTER TABLE [dbo].[SolicitantesAptitudes]
ADD CONSTRAINT [FK_NivelSolicitanteAptitud]
    FOREIGN KEY ([NivelId])
    REFERENCES [dbo].[Niveles]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NivelSolicitanteAptitud'
CREATE INDEX [IX_FK_NivelSolicitanteAptitud]
ON [dbo].[SolicitantesAptitudes]
    ([NivelId]);
GO

-- Creating foreign key on [NivelId] in table 'AptitudesRequeridas'
ALTER TABLE [dbo].[AptitudesRequeridas]
ADD CONSTRAINT [FK_NivelAptitudRequerida]
    FOREIGN KEY ([NivelId])
    REFERENCES [dbo].[Niveles]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NivelAptitudRequerida'
CREATE INDEX [IX_FK_NivelAptitudRequerida]
ON [dbo].[AptitudesRequeridas]
    ([NivelId]);
GO

-- Creating foreign key on [SolicitanteId] in table 'Alertas'
ALTER TABLE [dbo].[Alertas]
ADD CONSTRAINT [FK_SolicitanteAlerta]
    FOREIGN KEY ([SolicitanteId])
    REFERENCES [dbo].[Usuarios_Solicitante]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolicitanteAlerta'
CREATE INDEX [IX_FK_SolicitanteAlerta]
ON [dbo].[Alertas]
    ([SolicitanteId]);
GO

-- Creating foreign key on [CategoriaId] in table 'Alertas'
ALTER TABLE [dbo].[Alertas]
ADD CONSTRAINT [FK_CategoriaAlerta]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaAlerta'
CREATE INDEX [IX_FK_CategoriaAlerta]
ON [dbo].[Alertas]
    ([CategoriaId]);
GO

-- Creating foreign key on [DepartamentoId] in table 'Alertas'
ALTER TABLE [dbo].[Alertas]
ADD CONSTRAINT [FK_DepartamentoAlerta]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamentos]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoAlerta'
CREATE INDEX [IX_FK_DepartamentoAlerta]
ON [dbo].[Alertas]
    ([DepartamentoId]);
GO

-- Creating foreign key on [EmpresaId] in table 'Ofertas'
ALTER TABLE [dbo].[Ofertas]
ADD CONSTRAINT [FK_EmpresaOferta]
    FOREIGN KEY ([EmpresaId])
    REFERENCES [dbo].[Usuarios_Empresa]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmpresaOferta'
CREATE INDEX [IX_FK_EmpresaOferta]
ON [dbo].[Ofertas]
    ([EmpresaId]);
GO

-- Creating foreign key on [CategoriaId] in table 'Ofertas'
ALTER TABLE [dbo].[Ofertas]
ADD CONSTRAINT [FK_CategoriaOferta]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaOferta'
CREATE INDEX [IX_FK_CategoriaOferta]
ON [dbo].[Ofertas]
    ([CategoriaId]);
GO

-- Creating foreign key on [DepartamentoId] in table 'Ofertas'
ALTER TABLE [dbo].[Ofertas]
ADD CONSTRAINT [FK_DepartamentoOferta]
    FOREIGN KEY ([DepartamentoId])
    REFERENCES [dbo].[Departamentos]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartamentoOferta'
CREATE INDEX [IX_FK_DepartamentoOferta]
ON [dbo].[Ofertas]
    ([DepartamentoId]);
GO

-- Creating foreign key on [OfertaId1] in table 'Visitas'
ALTER TABLE [dbo].[Visitas]
ADD CONSTRAINT [FK_OfertaVisita]
    FOREIGN KEY ([OfertaId1])
    REFERENCES [dbo].[Ofertas]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfertaVisita'
CREATE INDEX [IX_FK_OfertaVisita]
ON [dbo].[Visitas]
    ([OfertaId1]);
GO

-- Creating foreign key on [TiempoContratacionId] in table 'Ofertas'
ALTER TABLE [dbo].[Ofertas]
ADD CONSTRAINT [FK_TiempoContratacionOferta]
    FOREIGN KEY ([TiempoContratacionId])
    REFERENCES [dbo].[TiemposContratacion]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TiempoContratacionOferta'
CREATE INDEX [IX_FK_TiempoContratacionOferta]
ON [dbo].[Ofertas]
    ([TiempoContratacionId]);
GO

-- Creating foreign key on [OfertaId] in table 'Solicitudes'
ALTER TABLE [dbo].[Solicitudes]
ADD CONSTRAINT [FK_OfertaSolicitud]
    FOREIGN KEY ([OfertaId])
    REFERENCES [dbo].[Ofertas]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfertaSolicitud'
CREATE INDEX [IX_FK_OfertaSolicitud]
ON [dbo].[Solicitudes]
    ([OfertaId]);
GO

-- Creating foreign key on [OfertaId1] in table 'AptitudesRequeridas'
ALTER TABLE [dbo].[AptitudesRequeridas]
ADD CONSTRAINT [FK_OfertaAptitudRequerida]
    FOREIGN KEY ([OfertaId1])
    REFERENCES [dbo].[Ofertas]
        ([Id])
    ;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OfertaAptitudRequerida'
CREATE INDEX [IX_FK_OfertaAptitudRequerida]
ON [dbo].[AptitudesRequeridas]
    ([OfertaId1]);
GO

-- Creating foreign key on [Id] in table 'Usuarios_Solicitante'
ALTER TABLE [dbo].[Usuarios_Solicitante]
ADD CONSTRAINT [FK_Solicitante_inherits_Usuario]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Usuarios_Empresa'
ALTER TABLE [dbo].[Usuarios_Empresa]
ADD CONSTRAINT [FK_Empresa_inherits_Usuario]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------