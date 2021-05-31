# CrudClientesMVC
Usando aspe .net con Entity framework 

# Tutorial de referencia 
https://www.youtube.com/watch?v=0Gu56u71G18&ab_channel=Develoteca

# Instalar El Entity Framework
1. click derecho sobre el proyecto y click en Administrador de paquetes nuget
2. en examniar buscar Entity y escoger el q dice Entity Framework nada mas la v6.4.4

# Conectar con la base de datos 
1. Click derecho en elproyecto 
15. (Nota se debe hacer clic sobre la carpeta models para un mejor orden en este caso Model1 es elmodelo peroe sta fuera de la carpeta model)
2. clic en agregar
3. clic en nuevo elemento
4. clic en Datos
5. seleccionamos la opcion DO.NET Data Model
6. como estandar ponemos el nombre de la Base
7. Seleccionamos la primer opcion
8. clic en nueva conexion
9. Seleccionamos SQL server
10.seleccionamos el nombre del server en este caso DESKTOP-LBVRCNO clave 12345
11. nos da una lista de base de datos en este caso seleccionamos CRUD
y aceptar
12. clic en siguiente
13. clic en finalizar
14. nos carga una imagen como con un diagrama de tablas

# Generar Controles y vistas por medio de EF (Entity Framework)
**Usaremos Database First**
**Crear controlador**
1. clic derecho en carpeta controllers => clic en controler => agregar => controller
2. seleccionamos laopcion "Controlador MVC con vistas que usa EF"
3. seleccionamos el modelo que creamos al conectar con la DB ( en este caso tblClientes) 
4. Seleccionamos el contecto creado al conectar la DB (En este caso CRUDEntities (CrudClientesMVC))
5. Seleccionamos el Layout que vamos a usar en la opcion que dice usar pagina de diseño
6. esta ubicado en vistas => shared => layout (~/Views/Shared/_Layout.cshtml) 
7. desmarcamos la opcion de referencias de scripts y clic en agregar 
    7.1 si te da error de se produjo un error intente regenerar el proyecto con un rebuild se soluciona
8. se crean los controllers vistas 

# Notas
1. si da error por cuestiond e longitud de campos lo mejor es crear de nuevo la conexion ala base de datos y probar si asi se actualziaron 
los cambiso hechos en la misma, si aun rpesenta error crear nuevamente como adicional el controlador 

# USAR STORE PROCEDURE CON EF Y MVC 
1. link https://www.youtube.com/watch?v=uZfxKjqdc9M&ab_channel=abctutorial
2. Nos vamos al diagrama y clic derecho => actualizar modelo de datos 
3. nos vamos a funciones y procedimientos almacenados y escogemos los sp que necesitemos y finalizar
4. Nos vamos al Explorador de modelos para ello ahcemos esto
5. clic en la opcion ver => otras ventanas => clic en explodaror de Entity Data Model
6. y ahi aparecen todos los sps extraidos de la DB 
