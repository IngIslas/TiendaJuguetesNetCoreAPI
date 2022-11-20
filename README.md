# TiendaJuguetesAPI

API RestFull para consumir y manipular el catalogo de juguetes de una Tienda


## Ejecutar localmente

Clonar el repositorio

```bash
  git clone https://github.com/IngIslas/TiendaJuguetesNetCoreAPI.git
```

Dirigirte al directorio del repositorio

```bash
  cd my-project
```
Iniciar el servidor

```bash
  dotnet run
```


## API Reference

#### Obtener todos los items

```http
  GET /api/juguete/GetJuguetes
```


#### Obtener un item

```http
  GET /api/Juguete/GetJuguete/{id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Requerido**. Id del item a buscar|


#### Insertar item

```http
  POST /api/Juguete/AgregarJuguete
```

| Parameter         | Type     | Description                                 |
| :-----------------| :------- | :-------------------------------------------|
| `nombre`          | `string` | **Requerido**. Nombre del item              |
| `descripcion`     | `string` | **Opcional**.  Descripion del item          |
| `restriccionEdad` | `int`    | **Opcional**.  Resrtriccion de edad del item|
| `compañia`        | `string` | **Requerido**. Compañia a la que pertenece  |
| `precio`          | `decimal`| **Requerido**. Precio del item              |


#### Editar item

```http
  PUT /api/Juguete/ActualizarJuguete/{id}
```

| Parameter         | Type      | Description                       |
| :-----------------| :-------  | :-------------------------------- |
| `id`              | `string`  | **Requerido**. Id del item a buscar|
| `nombre`          | `string`  | **Requerido**. Nombre del item              |
| `descripcion`     | `string`  | **Opcional**.  Descripion del item          |
| `restriccionEdad` | `int`     | **Opcional**.  Resrtriccion de edad del item|
| `compañia`        | `string`  | **Requerido**. Compañia a la que pertenece  |
| `precio`          | `decimal` | **Requerido**. Precio del item              |

#### Eliminar item
```http
  DELETE /api/EliminarJuguete/{id}
```

| Parameter | Type     | Description                          |
| :-------- | :------- | :------------------------------------|
| `id`      | `string` | **Requerido**. Id del item a eliminar|

