# Paquetes instalados y versiones exactas

- `Microsoft.EntityFrameworkCore` → Mapeado de objetos.
  Versión: **9.0.9**

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 9.0.9
```

- `Microsoft.EntityFrameworkCore.Tools` → Herramientas de consola para migraciones y actualización de base de datos.
  Versión: **9.0.9**

```bash
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.9
```

- `Pomelo.EntityFrameworkCore.MySql` → Proveedor de EF Core para MySQL/MariaDB.
  Versión: **9.0.0**

```bash
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 9.0.0
```

- Verificar paquetes instalados:

```bash
  dotnet list package
```

> Se recomienda usar exactamente las versiones indicadas para evitar conflictos de compatibilidad.

---

    Project 'System.Infrastructure' has the following package references
    [net8.0]:
    Top-level Package                          Requested   Resolved
    > Microsoft.EntityFrameworkCore            9.0.9       9.0.9   
    > Microsoft.EntityFrameworkCore.Tools      9.0.9       9.0.9   
    > Pomelo.EntityFrameworkCore.MySql         9.0.0       9.0.0 

---

Cree carpeta Data para Crear el DBcontext