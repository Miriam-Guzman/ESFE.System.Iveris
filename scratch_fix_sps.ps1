$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=15;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)

try {
    $conn.Open()
    $sqls = @'
CREATE OR ALTER PROCEDURE dbo.SP_BuscarPasajero
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_pasajero, nombre, apellido, pasaporte, id_ciudad
    FROM dbo.Pasajeros
    WHERE nombre LIKE '%' + @criterio + '%'
       OR apellido LIKE '%' + @criterio + '%'
       OR pasaporte LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND id_pasajero = TRY_CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_BuscarAeropuerto
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT a.id_aeropuerto, a.nombre, a.codigo_iata, a.id_ciudad, c.nombre_ciudad, p.nombre_pais
    FROM dbo.Aeropuertos a
    INNER JOIN dbo.Cuidades c ON a.id_ciudad = c.id_ciudad
    INNER JOIN dbo.Paises p ON c.id_pais = p.id_pais
    WHERE a.nombre LIKE '%' + @criterio + '%'
       OR a.codigo_iata LIKE '%' + @criterio + '%'
       OR c.nombre_ciudad LIKE '%' + @criterio + '%'
       OR p.nombre_pais LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND a.id_aeropuerto = TRY_CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_BuscarDestinos
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT 
        v.id_vuelo,
        ad.nombre + ' (' + cd.nombre_ciudad + ')' AS Destino,
        ao.codigo_iata + ' -> ' + ad.codigo_iata AS RutasDisponible,
        CONVERT(VARCHAR(16), v.fecha_salida, 120) AS HoraVuelo,
        v.numero_vuelo,
        v.id_aeropuerto_origen,
        v.id_aeropuerto_destino,
        v.fecha_salida,
        v.fecha_llegada
    FROM dbo.Vuelos v
    INNER JOIN dbo.Aeropuertos ao ON v.id_aeropuerto_origen = ao.id_aeropuerto
    INNER JOIN dbo.Aeropuertos ad ON v.id_aeropuerto_destino = ad.id_aeropuerto
    INNER JOIN dbo.Cuidades cd ON ad.id_ciudad = cd.id_ciudad
    WHERE ad.nombre LIKE '%' + @criterio + '%'
       OR cd.nombre_ciudad LIKE '%' + @criterio + '%'
       OR ao.codigo_iata LIKE '%' + @criterio + '%'
       OR ad.codigo_iata LIKE '%' + @criterio + '%'
       OR v.numero_vuelo LIKE '%' + @criterio + '%';
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_BuscarVuelosDetalle
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT 
        v.id_vuelo,
        v.numero_vuelo,
        ao.nombre + ' (' + ao.codigo_iata + ')' AS Origen,
        ad.nombre + ' (' + ad.codigo_iata + ')' AS Destino,
        v.fecha_salida AS Hora,
        v.fecha_llegada,
        av.modelo + ' (' + av.matricula + ')' AS AvionAsignado,
        ev.descripcion AS Estado,
        pa.codigo_puerta AS Puerta,
        v.id_aeropuerto_origen,
        v.id_aeropuerto_destino,
        v.id_avion,
        v.id_est_vuelo,
        v.id_puerta
    FROM dbo.Vuelos v
    INNER JOIN dbo.Aeropuertos ao ON v.id_aeropuerto_origen = ao.id_aeropuerto
    INNER JOIN dbo.Aeropuertos ad ON v.id_aeropuerto_destino = ad.id_aeropuerto
    INNER JOIN dbo.Aviones av ON v.id_avion = av.id_avion
    INNER JOIN dbo.Est_Vuelo ev ON v.id_est_vuelo = ev.id_est_vuelo
    INNER JOIN dbo.Puerta_Abordaje pa ON v.id_puerta = pa.id_puerta
    WHERE v.numero_vuelo LIKE '%' + @criterio + '%'
       OR ao.nombre LIKE '%' + @criterio + '%'
       OR ad.nombre LIKE '%' + @criterio + '%'
       OR ao.codigo_iata LIKE '%' + @criterio + '%'
       OR ad.codigo_iata LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND v.id_vuelo = TRY_CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_BuscarAvion
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_avion, modelo, capacidad, matricula
    FROM dbo.Aviones
    WHERE modelo LIKE '%' + @criterio + '%' 
       OR matricula LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND id_avion = TRY_CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_BuscarCliente
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_cliente, nombre, apellido, email, telefono, id_ciudad
    FROM dbo.Clientes
    WHERE nombre LIKE '%' + @criterio + '%'
       OR apellido LIKE '%' + @criterio + '%'
       OR email LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND id_cliente = TRY_CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_BuscarEmpleado
    @criterio VARCHAR(100)
AS
BEGIN
    SELECT id_empleado, nombre, apellido, email, telefono, id_cargo
    FROM dbo.Empleados
    WHERE nombre LIKE '%' + @criterio + '%'
       OR apellido LIKE '%' + @criterio + '%'
       OR email LIKE '%' + @criterio + '%'
       OR (TRY_CAST(@criterio AS INT) IS NOT NULL AND id_empleado = TRY_CAST(@criterio AS INT));
END;
'@
    $parts = $sqls -split '---SEP---'
    foreach ($p in $parts) {
        $trimmed = $p.Trim()
        if (![string]::IsNullOrWhiteSpace($trimmed)) {
            $cmd = $conn.CreateCommand()
            $cmd.CommandText = $trimmed
            $cmd.ExecuteNonQuery() | Out-Null
        }
    }
    Write-Host "Procedures updated with TRY_CAST successfully!"
    $conn.Close()
} catch {
    Write-Host "ERROR: $($_.Exception.Message)"
}
