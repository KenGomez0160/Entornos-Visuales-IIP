use Ejemplo
go

select * from personas.estudiante
go

alter procedure consultaEstudiante
as begin
	select  nombre, primerApellido, segundoApellido, edad, s.descripcion, c.nombreClase
                            from personas.estudiante e
                            inner join personas.sexo s
                            on e.sexo = s.codigoSexo
							inner join personas.clase c
							on e.codigoClase = c.codigoClase
end 
execute consultaEstudiante

--Procedimiento almacenado de insertar o agregar a la tabla personas.empleados
--@codigo, es la variable o parametro para espera recibir para realizar la insercion en el campo que corresponde
alter procedure insertarEstudiante(@codigo int, @nombre varchar(25), @apellido1 varchar(25), @apellido2 varchar(25),
									@edad int, @sexo char(1), @codigoClase char(6))
as begin 
insert into 
			personas.estudiante (codigo, 
		    nombre, primerApellido, segundoApellido, edad, sexo, codigoClase)
			values(@codigo,@nombre,@apellido1,@apellido2,@edad,@sexo,@codigoClase)
end

--Ejecutar el procedimiento donde solamente se le pasan los valores a ingresar
execute insertarEstudiante 37,'Dianeth','Diaz','Matute',34,'F','IF-325'
execute insertarEstudiante 38,'Alba','Diaz','Meza',20,'F','IF-326'
execute insertarEstudiante 39,'Mario','Meza','Soza',22,'M','IF-326'
execute insertarEstudiante 40,'Leslie','Diaz','Matute',23,'F','IF-325'
execute insertarEstudiante 41,'Michael','Guts','Mirra',23,'M','IF-325'
execute insertarEstudiante 42,'Luis','Sanchez', 'Meza', 24, 'M','IF-326'

--Se comprueba el resultado
SELECT * FROM personas.estudiante

--Procedimiento almacenado para eliminar un estudiante por codigo
create procedure elimarEstudiante(@codigo int)
as begin
	delete from personas.estudiante where codigo = @codigo
end
--39 es el codigo del estudiante a eliminar el registro
execute elimarEstudiante 40
SELECT * FROM personas.estudiante


-----------PROCEDIMIENTO MODIFICAR ESTUDIANTE
create procedure modificarEstudiante (@codigo int, @nombre varchar(25), 
					@apellido1 varchar(25), @apellido2 varchar(25), @edad int, @codigoClase char(6))
as begin
	UPDATE personas.estudiante 
	set nombre=@nombre, primerApellido=@apellido1, segundoApellido=@apellido2, edad=@edad, codigoClase=@codigoClase
	WHERE codigo =@codigo
end

execute modificarEstudiante 37, 'Maria', 'Gonzales', 'Meza', 29, 'IF-326'


