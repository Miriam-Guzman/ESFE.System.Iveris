$connString = "Server=sql8012.site4now.net;Database=db_acda63_iveridbaerolinea;User Id=db_acda63_iveridbaerolinea_admin;Password=Zuniga_7881;TrustServerCertificate=True;Connection Timeout=15;"
$conn = New-Object System.Data.SqlClient.SqlConnection($connString)
try {
    $conn.Open()
    $spScripts = @'
CREATE OR ALTER PROCEDURE dbo.SP_ListarAeropuerto
AS
BEGIN
    SELECT a.id_aeropuerto, a.nombre, a.codigo_iata, a.id_ciudad, c.nombre_ciudad, p.nombre_pais
    FROM dbo.Aeropuertos a
    INNER JOIN dbo.Cuidades c ON a.id_ciudad = c.id_ciudad
    INNER JOIN dbo.Paises p ON c.id_pais = p.id_pais;
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
       OR (ISNUMERIC(@criterio) = 1 AND a.id_aeropuerto = CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_ActualizarAeropuerto
    @id_aeropuerto INT,
    @nombre VARCHAR(150),
    @codigo_iata CHAR(3),
    @id_ciudad INT
AS
BEGIN
    UPDATE dbo.Aeropuertos
    SET nombre = @nombre,
        codigo_iata = @codigo_iata,
        id_ciudad = @id_ciudad
    WHERE id_aeropuerto = @id_aeropuerto;
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_EliminarAeropuerto
    @id_aeropuerto INT
AS
BEGIN
    DELETE FROM dbo.Aeropuertos WHERE id_aeropuerto = @id_aeropuerto;
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_ListarVuelosDetalle
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
    INNER JOIN dbo.Puerta_Abordaje pa ON v.id_puerta = pa.id_puerta;
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
       OR (ISNUMERIC(@criterio) = 1 AND v.id_vuelo = CAST(@criterio AS INT));
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_ListarDestinos
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
    INNER JOIN dbo.Cuidades cd ON ad.id_ciudad = cd.id_ciudad;
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
CREATE OR ALTER PROCEDURE dbo.SP_ListarPaises
AS
BEGIN
    SELECT id_pais, nombre_pais FROM dbo.Paises ORDER BY nombre_pais;
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_ListarMetPagos
AS
BEGIN
    SELECT id_met_pago, descripcion FROM dbo.Met_Pagos;
END;
---SEP---
CREATE OR ALTER PROCEDURE dbo.SP_ListarPagosDetalle
AS
BEGIN
    SELECT 
        p.id_pago,
        p.fecha_pago,
        p.monto,
        p.id_reserva,
        mp.descripcion AS MetodoPago,
        ep.descripcion AS EstadoPago,
        c.nombre + ' ' + c.apellido AS Cliente
    FROM dbo.Pagos p
    INNER JOIN dbo.Met_Pagos mp ON p.id_met_pago = mp.id_met_pago
    INNER JOIN dbo.Est_Pagos ep ON p.id_est_pago = ep.id_est_pago
    LEFT JOIN dbo.Reservas r ON p.id_reserva = r.id_reserva
    LEFT JOIN dbo.Clientes c ON r.id_cliente = c.id_cliente;
END;
'@
    $parts = $spScripts -split '---SEP---'
    foreach ($p in $parts) {
        $trimmed = $p.Trim()
        if (![string]::IsNullOrWhiteSpace($trimmed)) {
            $cmd = $conn.CreateCommand()
            $cmd.CommandText = $trimmed
            $cmd.ExecuteNonQuery() | Out-Null
        }
    }
    Write-Host "Helper SPs created successfully!"
    $conn.Close()
} catch {
    Write-Host "ERROR: $($_.Exception.Message)"
}
