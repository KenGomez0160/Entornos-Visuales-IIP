---------SELECCIONAR 3 TABLAS-----------------------
select e.nombre, e.primerApellido, e.edad, s.descripcion, c.nombreClase
                            from personas.estudiante e
                            inner join personas.sexo s
                            on e.sexo = s.codigoSexo
							inner join personas.clase c
							on e.codigoClase = c.codigoClase

--------INSERTAR---------------------------------------
insert into personas.clase values('IF-325', 'Entornos visuales')
insert into personas.clase values('IF-326', 'BBDD II')
insert into personas.estudiante values(0036,'Luis','Perez','Martinez',26,'M','IF-325')
--------MODIFICAR---------------------------------------
select * from personas.estudiante
UPDATE personas.estudiante 
set nombre='Olman', primerApellido='Mendez', segundoApellido='Mendez', edad=27, codigoClase='IF-325'
WHERE codigo ='36'
--------ELIMINAR---------------------------------------
delete from personas.estudiante where codigo = 0036

update personas.estudiante
set primerApellido='Ramos'
where codigo ='38'

