CREATE DATABASE IF NOT EXISTS mediatek86;
USE mediatek86;

CREATE TABLE service(
   idservice INT AUTO_INCREMENT,
   nom VARCHAR(50),
   PRIMARY KEY(idservice)
);

CREATE TABLE motif(
   idmotif INT AUTO_INCREMENT,
   libelle VARCHAR(128),
   PRIMARY KEY(idmotif)
);

CREATE TABLE personnel(
   idpersonnel INT AUTO_INCREMENT,
   nom VARCHAR(50),
   prenom VARCHAR(50),
   tel VARCHAR(15),
   mail VARCHAR(128),
   idservice INT NOT NULL,
   PRIMARY KEY(idpersonnel),
   FOREIGN KEY(idservice) REFERENCES service(idservice)
);

CREATE TABLE absence(
   idpersonnel INT,
   datedebut DATETIME,
   datefin DATETIME,
   idmotif INT NOT NULL,
   PRIMARY KEY(idpersonnel, datedebut),
   FOREIGN KEY(idpersonnel) REFERENCES personnel(idpersonnel),
   FOREIGN KEY(idmotif) REFERENCES motif(idmotif)
);

CREATE TABLE responsable(
   login VARCHAR(64),
   pwd VARCHAR(64)
);

INSERT INTO responsable (login, pwd)
    -> VALUES ('admin', SHA2('MdpAdmin', 256));

INSERT INTO motif (libelle) VALUES
    -> ('vacances'),
    -> ('maladie'),
    -> ('motif familial'),
    -> ('congé parental');

INSERT INTO service (nom) VALUES
    -> ('administratif'),
    -> ('médiation culturelle'),
    -> ('prêt');

ALTER TABLE personnel
ADD CONSTRAINT uq_personnel_mail UNIQUE (mail);


ALTER TABLE absence
ADD CONSTRAINT uq_absence_unique_dates UNIQUE (idpersonnel, datedebut, datefin);
