$sqlContent = Get-Content -Path "db_iveris.sql" -Raw -Encoding UTF8
# Split by GO commands (case insensitive on newline)
$batches = [System.Text.RegularExpressions.Regex]::Split($sqlContent, "^\s*GO\s*$", [System.Text.RegularExpressions.RegexOptions]::Multiline -bor [System.Text.RegularExpressions.RegexOptions]::IgnoreCase)

$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=30;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)

try {
    $conn.Open()
    Write-Host "Connected to database. Executing $($batches.Count) batches..."
    $batchIndex = 0
    $successCount = 0
    $errorCount = 0
    
    foreach ($batch in $batches) {
        $trimmed = $batch.Trim()
        if ([string]::IsNullOrWhiteSpace($trimmed)) {
            continue
        }
        $batchIndex++
        try {
            $cmd = $conn.CreateCommand()
            $cmd.CommandText = $trimmed
            $cmd.CommandTimeout = 60
            $cmd.ExecuteNonQuery() | Out-Null
            $successCount++
        } catch {
            Write-Host "Batch $batchIndex Error: $($_.Exception.Message)"
            $errorCount++
        }
    }
    Write-Host "Execution finished. Success: $successCount, Errors: $errorCount"
    $conn.Close()
} catch {
    Write-Host "Connection error: $($_.Exception.Message)"
}
