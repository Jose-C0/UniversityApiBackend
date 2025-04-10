# University API Backend

### Propósito del Proyecto

El proyecto tiene como objetivo gestionar entidades relacionadas con una universidad, como estudiantes, cursos, capítulos, categorías y usuarios.

### Estructura del Proyecto

- **Controladores**: Contiene controladores como `CategorysController`, `ChaptersController`, `CoursesController`, `StudentsController` y `UsersController`. Estos controladores exponen endpoints para realizar operaciones CRUD sobre las entidades correspondientes.
- **Modelos**: Define las entidades principales del dominio, como `Course`, `Student`, `Category`, etc.
- **Acceso a Datos**: Incluye el archivo `UniversityDBContext.cs`, que configura las relaciones entre las entidades y la base de datos.
- **Migraciones**: Contiene archivos generados por Entity Framework Core para gestionar los cambios en el esquema de la base de datos.

### Tecnologías Utilizadas

- **ASP.NET Core**: Para construir la API REST.
- **Entity Framework Core**: Para interactuar con la base de datos.
- **SQL Server**: Probablemente como base de datos.


### Relaciones entre Entidades

- **Relación Uno a Uno**: Entre `Chapter` y `Course`.
- **Relación Uno a Muchos**: Entre `Category` y `Course`.
- **Relación Muchos a Muchos**: Entre `Course` y `Student` (tabla intermedia `CourseStudent`).

### Configuración

- **Archivos de Configuración**:
  - `appsettings.json` y `appsettings.Development.json`: Configuran la aplicación, como la conexión a la base de datos.
  - `.vscode/settings.json`: Configuración específica para Visual Studio Code.

### Compilación y Ejecución

El proyecto utiliza el SDK de .NET 7 y puede ser ejecutado con:

```bash
dotnet run

```
