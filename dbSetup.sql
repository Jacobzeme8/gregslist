CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE Table IF NOT EXISTS houses(
  id INT AUTO_INCREMENT PRIMARY KEY,
  bedrooms INT NOT NUll,
  bathrooms DOUBLE NOT NULL,
  floors INT NOT NULL,
  address VARCHAR(50)
) default charset utf8 COMMENT "";


DROP table IF EXISTS cars;

INSERT INTO houses
(bedrooms, bathrooms, floors, address)
VALUES
(3, 2.5, 1, '13 Weast');

INSERT INTO houses
(bedrooms, bathrooms, floors, address)
VALUES
(5, 3, 2, '13 Sorth Way');

SELECT
*
FROM houses;
