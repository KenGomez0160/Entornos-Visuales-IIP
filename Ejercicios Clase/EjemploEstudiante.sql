create database Ejemplo
go

create schema personas
go

use Ejemplo
go
create table personas.clase(
	codigoClase char(6) primary key not null,
	nombreClase char(50)
)
create table personas.sexo (
	codigoSexo char(1) primary key not null,
	descripcion char(8)
)

alter table personas.sexo alter column descripcion char(9)
select * from personas.sexo
insert into personas.sexo values('F','Fememino')
insert into personas.sexo values('M','Masculino')
delete from personas.sexo where codigoSexo = 'M'

create table personas.estudiante(
	codigo int primary key not null,
	nombre varchar(25),
	primerApellido varchar(25),
	segundoApellido varchar(25),
	edad int,
	sexo char(1)FOREIGN KEY REFERENCES personas.sexo(codigoSexo),
	codigoClase char(6) FOREIGN KEY REFERENCES personas.clase(codigoClase) 
)

insert into personas.clase values('IF-325', 'Entornos visuales')



select codigo as Código, nombre as 'Nombre', primerApellido as 'Primer apellido', 
                           segundoApellido as 'Segundo apellido', edad as 'Edad', sexo as 'Sexo' from personas.estudiante

insert into personas.estudiante values(0036,'Luis','Perez','Martinez',26,'M','IF-325')

delete from personas.estudiante where codigo = 0036

--------------------------tabla estudiantes + clase
select nombre, primerApellido, segundoApellido, edad, sexo, c.nombreClase
from personas.estudiante e
inner join personas.clase c
on e.codigoClase = c.codigoClase

select * from personas.estudiante
select * from personas.sexo
select * from personas.clase