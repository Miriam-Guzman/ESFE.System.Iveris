$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=15;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)
try {
    $conn.Open()
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='Met_Pagos'"
    $reader = $cmd.ExecuteReader()
    Write-Host "=== COLUMNS IN Met_Pagos ==="
    while ($reader.Read()) {
        Write-Host "$($reader[0]): $($reader[1])"
    }
    $reader.Close()

    $cmd2 = $conn.CreateCommand()
    $cmd2.CommandText = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='Aeropuertos'"
    $reader2 = $cmd2.ExecuteReader()
    Write-Host "=== COLUMNS IN Aeropuertos ==="
    while ($reader2.Read()) {
        Write-Host "$($reader2[0]): $($reader2[1])"
    }
    $reader2.Close()

    $conn.Close()
} catch {
    Write-Host "ERROR: $($_.Exception.Message)"
}
