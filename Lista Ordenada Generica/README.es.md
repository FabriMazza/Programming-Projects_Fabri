# Lista Ordenada Genérica

## Descripción

Este programa implementa una estructura de datos de **lista ordenada genérica** en C# que mantiene automáticamente sus elementos en orden. La implementación incluye:

- **`ListaOrdenada<T>`**: Una clase genérica que almacena elementos de cualquier tipo comparable y los mantiene ordenados automáticamente
- **`Contacto`**: Una clase de ejemplo que demuestra cómo usar la lista ordenada con objetos personalizados
- **Pruebas automatizadas**: Suite completa de pruebas que valida toda la funcionalidad con enteros, cadenas y objetos personalizados

### Características Principales

- **Ordenamiento automático**: Los elementos siempre se mantienen en orden ascendente
- **Sin duplicados**: Previene agregar elementos duplicados
- **Implementación genérica**: Funciona con cualquier tipo que implemente `IComparable<T>`
- **Filtrado**: Soporta filtrar elementos con predicados personalizados
- **Acceso por índice**: Permite recuperar elementos por índice usando la notación `[]`

## Tecnologías

- **Lenguaje**: C# (C-Sharp)
- **.NET**: Requiere .NET SDK o .NET Framework runtime
- **Genéricos**: Utiliza tipos genéricos de C# y restricciones
- **Interfaces**: `IComparable<T>`, `IEnumerable<T>`

## Cómo Ejecutar

### Opción 1: Usando .NET CLI (Recomendado)

```bash
dotnet run --file ejercicio.cs
```

O compilar y ejecutar:

```bash
dotnet build ejercicio.cs
dotnet run
```

### Opción 2: Usando el Compilador de C#

```bash
csc ejercicio.cs
ejercicio.exe
```

### Opción 3: Usando Visual Studio

1. Abrir el archivo en Visual Studio
2. Presionar `F5` o hacer clic en "Iniciar" para ejecutar con depuración
3. O presionar `Ctrl+F5` para ejecutar sin depuración

### Salida Esperada

Si todas las pruebas pasan, verás una salida similar a:

```
[OK] Primer elemento
[OK] Segundo elemento
[OK] Tercer elemento
[OK] Cantidad de elementos
...
[OK] Tercer contacto tras eliminar Otro
```

Si alguna prueba falla, verás un mensaje de error indicando qué aserción falló.

## Autor

**Mazza Leon, Fabrizio Lautaro** 