# Create-with-Code-JuanDP

Proyecto del curso **Create with Code** desarrollado en Unity 6.2.

Tutoriales, cursos y rutas guiadas gratuitos para dominar las habilidades de desarrollo 3D en tiempo real para crear videojuegos, realidad virtual, realidad aumentada y más. [Unity Learn](https://learn.unity.com/).

Curso: [Create with Code](https://learn.unity.com/course/create-with-code)

![UNITY](Images/Unity.webp)
Descarga la plataforma de desarrollo Unity [Unity Hub](https://unity.com/es/download)

## Contents

- [Estructura de carpetas y archivos](#folder-and-file-structure)
- [Lección 1:](#requirements)
- [Autor](#autor)

## Folder and file structure

```
./
├── .editorconfig
├── gulpfile.js
├── package.json
├── README.md
|
├── gulp_tasks/                                * gulp tasks
|   ├── config/                                * gulp tasks config
│   |   ├── paths.js
│   |   └── aliases.js
│   |
|   └── task.js
|
├── screenshots/                               * responsive test screenshots
|
├── dev/                                       * site source
│   ├── images/                                * image sources
|   │
│   ├── pug/                                   * templates
|   |   ├── blocks/                            * blocks library
|   │   |   └── block.pug
|   │   ├── helpers/                           * helper mixins
|   │   ├── vendor/                            * third-party code
|   │   ├── layouts/                           * page layouts
|   │   └── pages/                             * main pages templates
|   │
│   ├── js/                                    * source js
|   |   ├── vendor/                            * vendor scripts library
|   |   ├── lib/                               * site scripts library
|   │   ├── head.js                            * head scripts
|   │   └── body.js                            * body scripts
|   │
|   ├── sass/                                  * sass preprocessor styles
|   |   ├── blocks/                            * blocks library
|   │   |   └── block.sass
|   │   ├── helpers/                           * mixins and vars
|   │   ├── vendor/                            * third-party code
|   │   ├── custom.sass
|   │   ├── noscript.sass
|   │   └── screen.sass
|   │
│   ├── helpers/                               * helper files
|   |   ├── favicon.ico
|   |   └── .htaccess
|   │
│   ├── fonts/                                 * font sources
|   │
│   └── data/                                  * configs and data for templates
│
└── build/                                     * built source
    ├── index.html
    ├── page.html
    |
    └── static/                                * static assets
        ├── css/                               * minified styles
        |
        ├── images/                            * minified images
        │
        ├── js/                                * minified assembled js
        |
        └── fonts/                             * @font-face-ready webfonts

```

## Lección 1

- [Node.js](http://nodejs.org/)
- Build sytem: [Grunt](http://gruntjs.com/) or [Gulp](http://gulpjs.com/)
- Optionally:
  - [Editorconfig](http://editorconfig.org/)

## 🧾 Autor

**Juan Díaz Pradp**
GIDS5101  
Estudiante de Ingeniería en la UTNG  
Curso: Creación de Videojuegos con Unity
