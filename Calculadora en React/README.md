# Calculadora en React

## Descripción

Aplicación web de una calculadora interactiva con diseño moderno inspirado en iOS. La interfaz simula un dispositivo móvil iPhone con notch y ofrece una experiencia de usuario fluida y responsive.

### Características

- **Operaciones básicas**: Suma (+), resta (-), multiplicación (×) y división (÷)
- **Funciones adicionales**: 
  - Cambio de signo (+/-)
  - Cálculo de porcentajes (%)
  - Botón de limpieza (AC)
- **Interfaz visual**: Diseño moderno con estilo iOS, incluyendo notch característico de iPhone
- **Responsive**: Se adapta a diferentes tamaños de pantalla
- **Display dinámico**: Muestra tanto el número actual como la expresión matemática completa

## Tecnologías Utilizadas

- **React 18.2.0**: Framework principal para construir la interfaz de usuario mediante componentes
- **ReactDOM 18.2.0**: Librería para renderizar componentes React en el DOM
- **Babel Standalone 7.23.5**: Transpilador JSX en tiempo real para el navegador
- **HTML5**: Estructura base del documento
- **CSS3**: Estilos y diseño visual (Grid Layout, Flexbox, transiciones)
- **JavaScript (ES6+)**: Lógica de la aplicación utilizando Hooks de React (useState, useEffect)

### Arquitectura

La aplicación está construida como un archivo HTML único y autocontenido que:
- Carga React, ReactDOM y Babel desde CDN (sin necesidad de instalación)
- Utiliza JSX directamente en el navegador mediante Babel Standalone
- Implementa un componente funcional de React con hooks para la gestión del estado

## Cómo Ejecutar

### Opción 1: Abrir directamente en el navegador

1. Navega hasta la carpeta donde se encuentra el archivo `calculadora.html`
2. Haz doble clic sobre el archivo o clic derecho → "Abrir con" → selecciona tu navegador preferido
3. La aplicación se ejecutará inmediatamente sin necesidad de configuración adicional

### Opción 2: Usando un servidor local (recomendado para desarrollo)

#### Con Python:
```bash
# Python 3
python -m http.server 8000

# Python 2
python -m SimpleHTTPServer 8000
```

#### Con Node.js (http-server):
```bash
npx http-server -p 8000
```

#### Con VS Code (extensión Live Server):
1. Instala la extensión "Live Server" en VS Code
2. Clic derecho sobre `calculadora.html`
3. Selecciona "Open with Live Server"

Luego abre tu navegador en `http://localhost:8000/calculadora.html`

## Navegadores Compatibles

- Google Chrome (recomendado)
- Mozilla Firefox
- Microsoft Edge
- Safari
- Cualquier navegador moderno que soporte ES6+

## Requisitos

- Conexión a internet (para cargar las librerías desde CDN)
- Navegador web moderno

## Autor

**Mazza Leon, Fabrizio Lautaro**  