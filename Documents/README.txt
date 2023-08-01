// ========================= UMS2021_API ========================= //

$-- .NET Core Library --$

Microsoft.EntityFrameworkCore (v3.1.32)
Microsoft.EntityFrameworkCore.SqlServer (v3.1.32)
Microsoft.EntityFrameworkCore.Tools (v3.1.32)
Microsoft.AspNetCore.Authentication.JwtBearer (v3.1.32)
Swashbuckle.AspNetCore (v6.5.0)

$-- Connection Strings --$

"ConnectionStrings": {
  "UMSConnection": "Server=DRXTECH\\SQLEXPRESS;Database=UMS06012014;Trusted_Connection=True;",
  "LTSConnection": "Server=DRXTECH\\SQLEXPRESS;Database=LTS011208;Trusted_Connection=True;"
},

$-- Scaffold DbContext --$

-- UMS DbContext

Scaffold-DbContext "Server=DRXTECH\SQLEXPRESS;Database=UMS06012014;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models/DB_UMS" -Context UMSDbContext -ContextDir "Context" -Force

-- LTS DbContext

Scaffold-DbContext "Server=DRXTECH\SQLEXPRESS;Database=LTS011208;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir "Models/DB_LTS" -Context LTSDbContext -ContextDir "Context" -Force

$-- --$