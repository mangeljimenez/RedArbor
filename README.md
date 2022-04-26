# RedArbor

API desarrollada en .Net Core la cual ejecuta un CRUD basado en ADO.

## Instación

Como prerequisito se debe tener instalado .NetCore 5 o superior instalado. Este proyecto tiene conexion con una base de datos LocalDB

Se puede clonar este repositorio desde el siguiente link 
(https://github.com/mangeljimenez/RedArbor.git)

En la carpeta Scripts ubicada en raiz del repositorio se encuentran adjuntos los scripts que se utilizaron para desarrollar este API

## Uso

Este proyecto puede ser consumido desde POSTMAN o utilizando la interfaz de swagger con la cual se ejecuta.


Si desea cambiar la cadena de conexion de este proyecto, lo puede hacer ingresando al archivo appsetings.json y buscar allí la siguientes propiedades

```json
"ConnectionStrings": {
    "DefaultConnection": "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=RedArborDB;Integrated Security=True"
  },
```

## Contribución
Cualquier observación sera bienvenida y recibida
