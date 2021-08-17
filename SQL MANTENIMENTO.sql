CREATE DATABASE IF NOT EXISTS `compras` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `compras`;

CREATE TABLE `productos` (
  `idProducto` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `precio` int DEFAULT NULL,
   `estado` int
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `factura` (
  `idFactura` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Nit` varchar(45) DEFAULT NULL,
  `total` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- inserciones de pruebas

INSERT INTO `productos` (`idProducto`, `Nombre`, `precio`) VALUES
(1, "Buzz Lighter", 300,1),
(2, "Mario", 500,1),
(1, "Luigi", 400,1);



-- MANTENIMIENTOS
-- ingreso

DELIMITER $$
CREATE PROCEDURE `ingCompra` (IN `id` int, IN `nom` VARCHAR(45),IN `pre` int, IN `est` int)  BEGIN
	insert into productos (idProducto, Nombre,precio,estado) values (id,nom,pre,est);
END$$

DELIMITER $$
CREATE PROCEDURE `consultaCompras` ()  BEGIN
	select idProducto, Nombre, precio from productos;
END$$

DELIMITER $$
CREATE PROCEDURE `bajaUser` (IN `id` INT)  BEGIN
	update productos set productos.estado= 0 where prodc.idProducto=id;
END$$

