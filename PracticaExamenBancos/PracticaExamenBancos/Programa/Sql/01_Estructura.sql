CREATE DATABASE IF NOT EXISTS dbpractica_pacientes CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE dbpractica_pacientes;
CREATE TABLE IF NOT EXISTS `tblempleado` (
  `idEmpleado` int NOT NULL AUTO_INCREMENT,
  `codigoEmpleado` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dpiEmpleado` char(13) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nitEmpleado` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nombresEmpleado` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `apellidosEmpleado` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `puestoEmpleado` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `generoEmpleado` char(1) COLLATE utf8mb4_unicode_ci NOT NULL COMMENT 'M = Masculino, F = Femenino',
  `fechaNacimientoEmpleado` date NOT NULL,
  `fechaContratacionEmpleado` date NOT NULL,
  `telefonoEmpleado` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `correoEmpleado` varchar(150) COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idEmpleado`),
  UNIQUE KEY `uqCodigoEmpleado` (`codigoEmpleado`),
  UNIQUE KEY `uqDpiEmpleado` (`dpiEmpleado`),
  UNIQUE KEY `uqNitEmpleado` (`nitEmpleado`),
  UNIQUE KEY `uqCorreoEmpleado` (`correoEmpleado`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblrol` (
  `idRol` int NOT NULL AUTO_INCREMENT,
  `nombreRol` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `descripcionRol` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idRol`),
  UNIQUE KEY `uqNombreRol` (`nombreRol`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblmodulo` (
  `idModulo` int NOT NULL AUTO_INCREMENT,
  `nombreModulo` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `descripcionModulo` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idModulo`),
  UNIQUE KEY `uqNombreModulo` (`nombreModulo`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblaplicacion` (
  `idAplicacion` int NOT NULL AUTO_INCREMENT,
  `idModulo` int NOT NULL,
  `nombreAplicacion` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `descripcionAplicacion` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idAplicacion`),
  KEY `idxAplicacionIdModulo` (`idModulo`),
  CONSTRAINT `Fk_Aplicacion_Modulo` FOREIGN KEY (`idModulo`) REFERENCES `tblmodulo` (`idModulo`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblusuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `idEmpleado` int NOT NULL,
  `nombreUsuario` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `contrasenaUsuario` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ultimoAccesoUsuario` datetime NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT '1',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `uqIdEmpleadoUsuario` (`idEmpleado`),
  UNIQUE KEY `uqUsuarioUsuario` (`nombreUsuario`),
  KEY `idxUsuarioIdEmpleado` (`idEmpleado`),
  CONSTRAINT `Fk_Usuario_Empleado` FOREIGN KEY (`idEmpleado`) REFERENCES `tblempleado` (`idEmpleado`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblrecuperacioncontrasena` (
  `idRecuperacionContrasena` int NOT NULL AUTO_INCREMENT,
  `idUsuario` int NOT NULL,
  `tokenRecuperacionContrasena` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `fechaExpiracionRecuperacionContrasena` datetime NOT NULL,
  `usadoRecuperacionContrasena` tinyint(1) NOT NULL DEFAULT '0',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idRecuperacionContrasena`),
  UNIQUE KEY `uqTokenRecuperacionContrasena` (`tokenRecuperacionContrasena`),
  KEY `idxRecuperacionContrasenaIdUsuario` (`idUsuario`),
  CONSTRAINT `Fk_RecuperacionContrasena_Usuario` FOREIGN KEY (`idUsuario`) REFERENCES `tblusuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblusuariorol` (
  `idUsuario` int NOT NULL,
  `idRol` int NOT NULL,
  `fechaAsignacionUsuarioRol` date NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idUsuario`,`idRol`),
  KEY `idxUsuarioRolIdRol` (`idRol`),
  CONSTRAINT `Fk_UsuarioRol_Rol` FOREIGN KEY (`idRol`) REFERENCES `tblrol` (`idRol`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk_UsuarioRol_Usuario` FOREIGN KEY (`idUsuario`) REFERENCES `tblusuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblrolmoduloaplicacion` (
  `idRol` int NOT NULL,
  `idModulo` int NOT NULL,
  `idAplicacion` int NOT NULL,
  `derInsertarRolModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `derEditarRolModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `derEliminarRolModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `derImprimirRolModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idRol`,`idModulo`,`idAplicacion`),
  KEY `idxRolModAplIdModulo` (`idModulo`),
  KEY `idxRolModAplIdAplicacion` (`idAplicacion`),
  CONSTRAINT `Fk_RolModuloAplicacion_Aplicacion` FOREIGN KEY (`idAplicacion`) REFERENCES `tblaplicacion` (`idAplicacion`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk_RolModuloAplicacion_Modulo` FOREIGN KEY (`idModulo`) REFERENCES `tblmodulo` (`idModulo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk_RolModuloAplicacion_Rol` FOREIGN KEY (`idRol`) REFERENCES `tblrol` (`idRol`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblusuariomoduloaplicacion` (
  `idUsuario` int NOT NULL,
  `idModulo` int NOT NULL,
  `idAplicacion` int NOT NULL,
  `derInsertarUsuarioModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `derEditarUsuarioModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `derEliminarUsuarioModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `derImprimirUsuarioModuloAplicacion` tinyint(1) NOT NULL DEFAULT '0',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`idUsuario`,`idModulo`,`idAplicacion`),
  KEY `idxUsrModAplIdModulo` (`idModulo`),
  KEY `idxUsrModAplIdAplicacion` (`idAplicacion`),
  CONSTRAINT `Fk_UsuarioModuloAplicacion_Aplicacion` FOREIGN KEY (`idAplicacion`) REFERENCES `tblaplicacion` (`idAplicacion`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk_UsuarioModuloAplicacion_Modulo` FOREIGN KEY (`idModulo`) REFERENCES `tblmodulo` (`idModulo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk_UsuarioModuloAplicacion_Usuario` FOREIGN KEY (`idUsuario`) REFERENCES `tblusuario` (`idUsuario`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS `tblbitacora` (
  `idBitacora` int NOT NULL AUTO_INCREMENT,
  `idUsuario` int DEFAULT NULL,
  `accionBitacora` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tablaBitacora` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `idRegistroBitacora` int NOT NULL,
  `detallesBitacora` text COLLATE utf8mb4_unicode_ci NOT NULL,
  `ipBitacora` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `fechaHoraBitacora` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idBitacora`),
  KEY `idxBitacoraIdUsuario` (`idUsuario`),
  KEY `idxBitacoraFechaHora` (`fechaHoraBitacora`),
  KEY `idxBitacoraTabla` (`tablaBitacora`),
  CONSTRAINT `Fk_Bitacora_Usuario` FOREIGN KEY (`idUsuario`) REFERENCES `tblusuario` (`idUsuario`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=249 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
CREATE TABLE IF NOT EXISTS tblReporte (
    numeroReporte INT NOT NULL,
    nombreReporte VARCHAR(150) NOT NULL,
    rutaReporte VARCHAR(500) NOT NULL,
    fechaReporte DATE NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_Reporte PRIMARY KEY (numeroReporte),
    CONSTRAINT uqNombreReporte UNIQUE (nombreReporte)
) ENGINE=InnoDB;
CREATE TABLE IF NOT EXISTS tblAplicacionReporte (
    idAplicacion INT NOT NULL,
    numeroReporte INT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,

    CONSTRAINT Pk_AplicacionReporte PRIMARY KEY (idAplicacion, numeroReporte),
    CONSTRAINT Fk_Aplicacion_IdAplicacion FOREIGN KEY (idAplicacion)
        REFERENCES tblAplicacion (idAplicacion) ON DELETE RESTRICT ON UPDATE CASCADE,
    CONSTRAINT Fk_Reporte_NumeroReporte FOREIGN KEY (numeroReporte)
        REFERENCES tblReporte (numeroReporte) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB;
CREATE TABLE IF NOT EXISTS tblConsulta (
    Pk_Consulta INT AUTO_INCREMENT PRIMARY KEY,
    nombreConsulta VARCHAR(100) NOT NULL,
    aplicacionConsulta VARCHAR(30) NOT NULL,
    queryConsulta TEXT NOT NULL,
    fechaCreacionConsulta DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
        ON UPDATE CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS tbl_paciente (
 pk_idPaciente INT NOT NULL,
 nombrePaciente VARCHAR(50), apellidoPaciente VARCHAR(50),
 fechaNacimientoPaciente DATE, sexoPaciente VARCHAR(15),
 direccionPaciente VARCHAR(30), telefonoPaciente VARCHAR(20), estadoPaciente INT,
 PRIMARY KEY(pk_idPaciente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
