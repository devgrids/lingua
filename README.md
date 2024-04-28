# lingua


// conectar db 
Scaffold-DbContext "Server=LEONIDAS-MV\SQLEXPRESS; Database=lingua; Trusted_Connection=True; TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models


// forzar cambios
Scaffold-DbContext "Server=LEONIDAS-MV\SQLEXPRESS; Database=lingua; Trusted_Connection=True; TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force