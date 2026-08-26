$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=15;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)

try {
    $conn.Open()
    Write-Host "--- 1. Testing Pasajeros SPs ---"
    # Test Insertar Pasajero
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_InsertarPasajero @nombre='TestNombre', @apellido='TestApellido', @pasaporte='PASSTEST01', @id_ciudad=1"
    $cmd.ExecuteNonQuery() | Out-Null
    Write-Host "-> SP_InsertarPasajero: OK"

    # Test Buscar Pasajero
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_BuscarPasajero @criterio='PASSTEST01'"
    $reader = $cmd.ExecuteReader()
    $testId = 0
    if ($reader.Read()) {
        $testId = $reader["id_pasajero"]
        Write-Host "-> SP_BuscarPasajero: Found passenger ID $testId"
    }
    $reader.Close()

    # Test Actualizar Pasajero
    if ($testId -gt 0) {
        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_ActualizarPasajero @id_pasajero=$testId, @nombre='TestNombreMod', @apellido='TestApellidoMod', @pasaporte='PASSTEST01', @id_ciudad=1"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_ActualizarPasajero: OK"

        # Test Eliminar Pasajero
        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_EliminarPasajero @id_pasajero=$testId"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_EliminarPasajero: OK"
    }

    Write-Host "--- 2. Testing Destinos / Aeropuertos SPs ---"
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_ListarDestinos"
    $reader = $cmd.ExecuteReader()
    $destCount = 0
    while ($reader.Read()) { $destCount++ }
    $reader.Close()
    Write-Host "-> SP_ListarDestinos: $destCount rows returned"

    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_InsertarAeropuerto @nombre='Aeropuerto Test', @codigo_iata='TST', @id_ciudad=1"
    $cmd.ExecuteNonQuery() | Out-Null
    Write-Host "-> SP_InsertarAeropuerto: OK"

    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_BuscarAeropuerto @criterio='TST'"
    $reader = $cmd.ExecuteReader()
    $aeroId = 0
    if ($reader.Read()) { $aeroId = $reader["id_aeropuerto"] }
    $reader.Close()
    Write-Host "-> SP_BuscarAeropuerto: Found airport ID $aeroId"

    if ($aeroId -gt 0) {
        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_ActualizarAeropuerto @id_aeropuerto=$aeroId, @nombre='Aeropuerto Test Mod', @codigo_iata='TSM', @id_ciudad=1"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_ActualizarAeropuerto: OK"

        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_EliminarAeropuerto @id_aeropuerto=$aeroId"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_EliminarAeropuerto: OK"
    }

    Write-Host "--- 3. Testing Vuelos SPs ---"
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_ListarVuelosDetalle"
    $reader = $cmd.ExecuteReader()
    $vueloCount = 0
    while ($reader.Read()) { $vueloCount++ }
    $reader.Close()
    Write-Host "-> SP_ListarVuelosDetalle: $vueloCount rows returned"

    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_InsertarVuelo @numero_vuelo='IV-TEST99', @fecha_salida='2026-09-01 10:00', @fecha_llegada='2026-09-01 14:00', @id_aeropuerto_origen=1, @id_aeropuerto_destino=2, @id_avion=1, @id_est_vuelo=1, @id_puerta=1"
    $cmd.ExecuteNonQuery() | Out-Null
    Write-Host "-> SP_InsertarVuelo: OK"

    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_BuscarVuelosDetalle @criterio='IV-TEST99'"
    $reader = $cmd.ExecuteReader()
    $vueloId = 0
    if ($reader.Read()) { $vueloId = $reader["id_vuelo"] }
    $reader.Close()
    Write-Host "-> SP_BuscarVuelosDetalle: Found flight ID $vueloId"

    if ($vueloId -gt 0) {
        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_ActualizarVuelo @id_vuelo=$vueloId, @numero_vuelo='IV-TEST99MOD', @fecha_salida='2026-09-01 11:00', @fecha_llegada='2026-09-01 15:00', @id_aeropuerto_origen=1, @id_aeropuerto_destino=2, @id_avion=1, @id_est_vuelo=1, @id_puerta=1"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_ActualizarVuelo: OK"

        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_EliminarVuelo @id_vuelo=$vueloId"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_EliminarVuelo: OK"
    }

    Write-Host "--- 4. Testing Pagos SPs ---"
    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_ListarPagosDetalle"
    $reader = $cmd.ExecuteReader()
    $pagoCount = 0
    while ($reader.Read()) { $pagoCount++ }
    $reader.Close()
    Write-Host "-> SP_ListarPagosDetalle: $pagoCount rows returned"

    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "EXEC dbo.SP_InsertarPago @fecha_pago='2026-08-25', @monto=150.00, @id_reserva=1, @id_est_pago=1, @id_met_pago=1"
    $cmd.ExecuteNonQuery() | Out-Null
    Write-Host "-> SP_InsertarPago: OK"

    $cmd = $conn.CreateCommand()
    $cmd.CommandText = "SELECT TOP 1 id_pago FROM dbo.Pagos ORDER BY id_pago DESC"
    $pagoId = [int]$cmd.ExecuteScalar()
    Write-Host "-> Created Payment ID: $pagoId"

    if ($pagoId -gt 0) {
        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_ActualizarPago @id_pago=$pagoId, @fecha_pago='2026-08-25', @monto=175.00, @id_reserva=1, @id_est_pago=1, @id_met_pago=1"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_ActualizarPago: OK"

        $cmd = $conn.CreateCommand()
        $cmd.CommandText = "EXEC dbo.SP_EliminarPago @id_pago=$pagoId"
        $cmd.ExecuteNonQuery() | Out-Null
        Write-Host "-> SP_EliminarPago: OK"
    }

    Write-Host "=== ALL TESTS COMPLETED SUCCESSFULLY! ==="
    $conn.Close()
} catch {
    Write-Host "ERROR: $($_.Exception.Message)"
}
