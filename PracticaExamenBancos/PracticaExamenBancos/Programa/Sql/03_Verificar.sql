USE dbpractica_pacientes;
SELECT * FROM tbl_paciente ORDER BY pk_idPaciente;
SELECT u.nombreUsuario,b.accionBitacora,b.tablaBitacora,b.idRegistroBitacora,
       b.detallesBitacora,b.fechaHoraBitacora
FROM tblbitacora b JOIN tblusuario u ON u.idUsuario=b.idUsuario
WHERE b.tablaBitacora='tbl_paciente' ORDER BY b.idBitacora;
