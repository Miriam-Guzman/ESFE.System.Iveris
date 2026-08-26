$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=15;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)
try {
    $conn.Open()
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "SELECT ROUTINE_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE='PROCEDURE' ORDER BY ROUTINE_NAME"
    $reader = $cmd.ExecuteReader()
    Write-Host "=== ALL PROCEDURES IN DB ==="
    while ($reader.Read()) {
        Write-Host "$($reader[0])"
    }
    $reader.Close()
    $conn.Close()
} catch {
    Write-Host "ERROR: $($_.Exception.Message)"
}
