# Biblioteca del Arquitecto

Proyecto de consola en C# para el Sistema de Biblioteca. Desarrollado para las evidencias EV06 (menú interactivo con sintaxis básica) y EV07 (modelo de dominio con POO).

## Estructura

```text
biblioteca-del-arquitecto/
├── Models/
│   ├── EstadoPrestamo.cs
│   ├── Libro.cs
│   ├── Prestamo.cs
│   └── Usuario.cs
├── Program.cs
├── biblioteca-del-arquitecto.csproj
└── README.md
```

## Ejecución

```bash
dotnet restore
dotnet build
dotnet run
```

## Git Flow

Ramas base:

- `main`: incrementos estables del sistema.
- `develop`: rama de integración de las features.

Ramas `feature/*` utilizadas:

**EV06**

- `feature/project-bootstrap`
- `feature/main-menu-navigation`
- `feature/books-menu`
- `feature/users-menu`
- `feature/loans-menu`
- `feature/search-reports-menu`
- `feature/persistence-menu`
- `feature/exit-flow`

**EV07**

- `feature/models-libro`
- `feature/models-usuario`
- `feature/models-prestamo`
- `feature/models-enum-estado-prestamo`
- `feature/models-testing-objetos`

Flujo de trabajo aplicado:

```bash
git checkout develop
git checkout -b feature/nombre-feature

git add .
git commit -m "feat: descripcion del cambio"

git checkout develop
git merge --no-ff feature/nombre-feature
```

El historial se integra en `develop` mediante merges y el cierre del incremento se realiza con el merge `develop -> main`.
