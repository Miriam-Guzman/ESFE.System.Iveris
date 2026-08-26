$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=15;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)
try {
    $conn.Open()
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = @"
SELECT 'Paises' as Tabla, COUNT(*) as Total FROM Paises
UNION ALL SELECT 'Cuidades', COUNT(*) FROM Cuidades
UNION ALL SELECT 'Aeropuertos', COUNT(*) FROM Aeropuertos
UNION ALL SELECT 'Aviones', COUNT(*) FROM Aviones
UNION ALL SELECT 'Est_Vuelo', COUNT(*) FROM Est_Vuelo
UNION ALL SELECT 'Puerta_Abordaje', COUNT(*) FROM Puerta_Abordaje
UNION ALL SELECT 'Vuelos', COUNT(*) FROM Vuelos
UNION ALL SELECT 'Pasajeros', COUNT(*) FROM Pasajeros
UNION ALL SELECT 'Met_Pagos', COUNT(*) FROM Met_Pagos
UNION ALL SELECT 'Est_Pagos', COUNT(*) FROM Est_Pagos
UNION ALL SELECT 'Pagos', COUNT(*) FROM Pagos
UNION ALL SELECT 'Clientes', COUNT(*) FROM Clientes
UNION ALL SELECT 'Reservas', COUNT(*) FROM Reservas
"@
    $reader = $cmd.ExecuteReader()
    while ($reader.Read()) {
        Write-Host "$($reader[0]): $($reader[1])"
    }
    $reader.Close()
    $conn.Close()
} catch {
    Write-Host "ERROR: $($_.Exception.Message)"
}
