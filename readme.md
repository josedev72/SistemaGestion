Trabajo Práctico de C# - Desafío 03 - SistemaGestion

Nota: TP desarrollado con Arquitectura en capas y conexion a SQL Server

Funcionamiento:

	1- Al seleccionar una tabla (opción del objeto combo / lista, carga la tabla correspondiente en el grid)

	2- Seleccionar del combo la tabla y luego Nuevo o Eliminar para su correspondiente Acción.

	3- En forms correspondientes a cada tabla se pueden modificar los datos o desde el boton "Volver" cancela la edición.

---------------------------
Trabajo Práctico de C# - Desafío 04 - SistemaGestion-WinFormConsumoApi

Nota: Se agregó al TP Anterior un proyecto Winform que consume la Api, para correrlo, 
	  primero debe estar funcionando el proyecto SistemaGestionWebApi.
	  Se puede cambiar la url de la Api en en App.config.

	  Se agregó Loguin, usuario válido = "jose", pass = "123".

	  Tener en cuenta que son varios proyectos juntos:
			* SistemaGestionUI (App WinForm Ado.Net), aquí esta la solucion gral. del proyecto completo (SistemaGestionUI.sln) 
			* SistemaGestionWebApi (Api)
			* SistemaGestion-WinFormConsumoApi (App WinForm que consume la Api)

