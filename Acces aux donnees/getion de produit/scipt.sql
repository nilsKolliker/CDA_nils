CREATE TABLE Categories(
   IdCategorie INT AUTO_INCREMENT PRIMARY KEY,
   LibelleCategorie VARCHAR(50)  NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Rayons(
   IdRayon INT AUTO_INCREMENT PRIMARY KEY,
   LibelleRayon VARCHAR(50)  NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Produits(
   IdProduit INT AUTO_INCREMENT PRIMARY KEY,
   LibelleProduit VARCHAR(50)  NOT NULL,
   IdCategorie INT NOT NULL,
   IdRayon INT NOT NULL,
   FOREIGN KEY(IdCategorie) REFERENCES Categories(IdCategorie),
   FOREIGN KEY(IdRayon) REFERENCES Rayons(IdRayon)
)ENGINE=InnoDB;
