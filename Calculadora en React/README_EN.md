# React Calculator

## Description

Interactive calculator web application with a modern iOS-inspired design. The interface simulates an iPhone mobile device with notch and offers a smooth and responsive user experience.

### Features

- **Basic operations**: Addition (+), subtraction (-), multiplication (×), and division (÷)
- **Additional functions**: 
  - Sign change (+/-)
  - Percentage calculation (%)
  - Clear button (AC)
- **Visual interface**: Modern iOS-style design, including the characteristic iPhone notch
- **Responsive**: Adapts to different screen sizes
- **Dynamic display**: Shows both the current number and the complete mathematical expression

## Technologies Used

- **React 18.2.0**: Main framework for building the user interface through components
- **ReactDOM 18.2.0**: Library for rendering React components in the DOM
- **Babel Standalone 7.23.5**: Real-time JSX transpiler for the browser
- **HTML5**: Base document structure
- **CSS3**: Styles and visual design (Grid Layout, Flexbox, transitions)
- **JavaScript (ES6+)**: Application logic using React Hooks (useState, useEffect)

### Architecture

The application is built as a single, self-contained HTML file that:
- Loads React, ReactDOM, and Babel from CDN (no installation required)
- Uses JSX directly in the browser via Babel Standalone
- Implements a functional React component with hooks for state management

## How to Run

### Option 1: Open directly in the browser

1. Navigate to the folder where the `calculadora.html` file is located
2. Double-click on the file or right-click → "Open with" → select your preferred browser
3. The application will run immediately without any additional configuration

### Option 2: Using a local server (recommended for development)

#### With Python:
```bash
# Python 3
python -m http.server 8000

# Python 2
python -m SimpleHTTPServer 8000
```

#### With Node.js (http-server):
```bash
npx http-server -p 8000
```

#### With VS Code (Live Server extension):
1. Install the "Live Server" extension in VS Code
2. Right-click on `calculadora.html`
3. Select "Open with Live Server"

Then open your browser at `http://localhost:8000/calculadora.html`

## Compatible Browsers

- Google Chrome (recommended)
- Mozilla Firefox
- Microsoft Edge
- Safari
- Any modern browser that supports ES6+

## Requirements

- Internet connection (to load libraries from CDN)
- Modern web browser

## Author

**Mazza Leon, Fabrizio Lautaro** 