CREATE DATABASE IF NOT EXISTS panchovilla;
USE panchovilla;

CREATE TABLE IF NOT EXISTS cliente (					#Tabla Cliente
		id_cliente 			VARCHAR(5),
		nombre		 		VARCHAR(20) NOT NULL,
		apellidos 			VARCHAR(20),
		fecha_nacimiento 	DATE,
		sexo 					BOOL,
		pais 					VARCHAR(20),
		ciudad 				VARCHAR(20),
		mail 					VARCHAR(30),
		fecha_registro 	LONGBLOB,
		estado 				VARCHAR(10),
    PRIMARY KEY (id_cliente)
    
CREATE TABLE IF NOT EXISTS pagos_activos (			#Tabla pagos_activos
		id_pago 				VARCHAR(5),
		id_reservacion		VARCHAR(5),
		monto					DECIMAL(10,2),
		fecha 				DATE,
		nota 					VARCHAR(150),
		estado 				VARCHAR(15),
    PRIMARY KEY (id_pago)
    
CREATE TABLE IF NOT EXISTS pagos_historial (			#Tabla pagos_historial
		id_pago 				VARCHAR(5),
		id_reservacion		VARCHAR(5),
		monto					DECIMAL(10,2),
		fecha 				DATE,
		nota 					VARCHAR(150),
		estado 				VARCHAR(15),
    PRIMARY KEY (id_pago)
    
CREATE TABLE IF NOT EXISTS reservacion_activa (			#Tabla reservacion_activa
		id_reservacion 	VARCHAR(5),
		id_cliente 			VARCHAR(5),
		id_cabana 			VARCHAR(15),
		no_personas 		INT,
		fecha_ingreso 		DATE,
		fecha_egreso 		DATE,
		moneda 				VARCHAR(10),
		descuento 			DECIMAL(5,2),
		precio_noche 		DECIMAL(10,2),
		total_dias 			INT,
		total_pago 			DECIMAL(10,2),
		abono 				DECIMAL(10,2),
		nota 					VARCHAR(150),
		estancia 			VARCHAR(10),
		fecha_registro 	DATE,
		estado 				VARCHAR(15),
    PRIMARY KEY (id_reservacion)
    
CREATE TABLE IF NOT EXISTS reservacion_historial (			#Tabla reservacion_historial
		id_reservacion 	VARCHAR(5),
		id_cliente 			VARCHAR(5),
		id_cabana 			VARCHAR(15),
		no_personas 		INT,
		fecha_ingreso 		DATE,
		fecha_egreso 		DATE,
		moneda 				VARCHAR(10),
		descuento 			DECIMAL(5,2),
		precio_noche 		DECIMAL(10,2),
		total_dias 			INT,
		total_pago 			DECIMAL(10,2),
		abono 				DECIMAL(10,2),
		nota 					VARCHAR(150),
		estancia 			VARCHAR(10),
		fecha_registro 	DATE,
		estado 				VARCHAR(15),
    PRIMARY KEY (id_reservacion)
    
CREATE TABLE IF NOT EXISTS egresos (			#Tabla egresos
		id_egreso 			VARCHAR(5),
		monto					DECIMAL(10,2),
		fecha 				DATE,
		nota 					VARCHAR(150),
		estado 				VARCHAR(15),
    PRIMARY KEY (id_egreso)
    







#    ________________________________________________________________________________________________________________________________________
#   /PROCEDIMIENTOS ALMACENADOS *********PROCEDIMIENTOS ALMACENADOS*********PROCEDIMIENTOS ALMACENADOS********PROCEDIMIENTOS ALMACENADOS*****\
#  --------------------------------------------------------------------------------------------------------------------------------------------





