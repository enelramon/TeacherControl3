
create table Asignaturas(
	IdAsignatura int identity(1,1) primary key NOT NULL,
	Codigo int NOT NULL,
	Nombre varchar(30) NOT NULL,
	Ceditos int not null,
	esActivo bit NOT NULL
)


Create Table Tareas( IdTarea int identity(1,1) primary key NOT NULL,
CodigoTarea varchar(10) not null,
Fecha datetime  not null,
Vence datetime not null,
IdSemestre int not null,
IdAsignatura int not null,
Descripcion varchar(200)  not null)


Create Table Semestres(IdSemestre int identity(1,1) primary key NOT NULL,
Codigo varchar(6),
FechaInicio date,
FechaFin date,
FechaParcial1 date,
FechaParcial2 date,
FechaFinal date,
esActivo bit)

Create Table EvaluacionesTareas(IdEvaluacion int identity(1,1) primary key NOT NULL,
Fecha datetime  not null,
IdTarea Int  not null,
IdEstudiante int not null,
Calificacion int not null)


Create Table Usuarios (IdUsuario int  identity(1,1) primary key ,
 Nombre varchar(50),
 Clave varchar(10),
 Email varchar(50),
 esActivo bit)


Create Table Estudiantes(
IdRegistro int identity(1,1) primary key,
Nombres varchar(50),
Apellidos varchar(50),
Telefono varchar(50),
Celular varchar(50),
Fecha DateTime,
Direccion varchar(50),
Email varchar(50)
);