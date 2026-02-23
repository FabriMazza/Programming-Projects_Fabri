# Sistema de Gestión de Exámenes Multiple Choice

## Descripción

Este es un sistema de gestión de exámenes de opción múltiple desarrollado en C# que permite a los profesores crear preguntas y a los alumnos realizar exámenes. El sistema almacena los resultados y proporciona reportes estadísticos detallados.

## Funcionalidades

- **Registro de Preguntas**: Permite crear preguntas con tres opciones de respuesta (A, B, C) y especificar la respuesta correcta.
- **Tomar Exámenes**: Los alumnos pueden realizar exámenes con 5 preguntas seleccionadas aleatoriamente del banco de preguntas.
- **Sistema de Calificación**: El sistema calcula automáticamente la nota final en escala de 0 a 10.
- **Reportes Detallados**:
  - Ver todos los exámenes realizados
  - Filtrar resultados por alumno
  - Ranking de mejores alumnos
  - Estadísticas por pregunta (porcentaje de respuestas correctas)

## Tecnologías Utilizadas

- **Lenguaje**: C# (.NET 9.0)
- **Framework ORM**: Entity Framework Core 9.0.4
- **Base de Datos**: SQLite 9.0.4
- **Tipo de Aplicación**: Consola

## Requisitos Previos

- .NET SDK 9.0 o superior

## Instalación y Ejecución

### 1. Clonar o descargar el proyecto

```bash
git clone <url-del-repositorio>
cd "Gestion Examenes Multiple Choice"
```

### 2. Restaurar dependencias

```bash
dotnet restore
```

### 3. Ejecutar el programa

```bash
dotnet run
```

### 4. Compilar (opcional)

```bash
dotnet build
```

## Uso del Programa

Al ejecutar el programa, aparecerá un menú principal con las siguientes opciones:

1. **Registrar pregunta**: Permite agregar nuevas preguntas al banco de preguntas
2. **Tomar examen**: Permite que un alumno realice un examen con 5 preguntas aleatorias
3. **Ver reportes**: Accede a diferentes tipos de reportes y estadísticas
0. **Salir**: Cierra el programa

### Ejemplo de Uso

#### Registrar una Pregunta
```
Enunciado: ¿Cuál es la capital de Argentina?
Respuesta A: Buenos Aires
Respuesta B: Córdoba
Respuesta C: Rosario
Respuesta correcta (A/B/C): A
```

#### Tomar un Examen
- Ingresa el nombre del alumno
- Responde las 5 preguntas presentadas
- El sistema calcula y muestra la nota final automáticamente

## Estructura del Proyecto

- `Program.cs`: Archivo principal con toda la lógica de la aplicación
- `tp4.csproj`: Archivo de configuración del proyecto
- `examen.db`: Base de datos SQLite (se crea automáticamente al ejecutar)

## Modelo de Datos

El sistema utiliza tres entidades principales:

- **Pregunta**: Almacena las preguntas con sus opciones y respuesta correcta
- **ResultadoExamen**: Guarda los resultados de cada examen realizado
- **RespuestaExamen**: Registra cada respuesta individual de un examen

## Autor

Mazza Leon, Fabrizio Lautaro - 61848
