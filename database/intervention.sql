-- =====================================================================
--  SyGITech — base "intervention" (SQL Server / SQL Express / LocalDB)
--  Schéma reconstruit depuis interventionDataSet.xsd (clés primaires incluses).
--  Exécuter :  sqlcmd -S .\SQLEXPRESS -i intervention.sql
-- =====================================================================
IF DB_ID('intervention') IS NULL CREATE DATABASE intervention;
GO
USE intervention;
GO

CREATE TABLE TECHNICIEN (
    CodTech    NVARCHAR(50) NOT NULL PRIMARY KEY,
    NomTech    NVARCHAR(50) NOT NULL,
    PrenomTech NVARCHAR(50) NOT NULL
);

CREATE TABLE CLIENT (
    NumCli     NVARCHAR(50) NOT NULL PRIMARY KEY,
    NomCli     NVARCHAR(50) NOT NULL,
    AdresCli   NVARCHAR(50) NOT NULL,
    TelCli     INT          NOT NULL,
    TypCli     NVARCHAR(50) NOT NULL,
    LieuInterv NVARCHAR(50) NOT NULL
);

CREATE TABLE GROUPE (
    NumGroup NVARCHAR(50) NOT NULL PRIMARY KEY,
    NomGroup NVARCHAR(50) NOT NULL,
    CodTech  NVARCHAR(50) NOT NULL REFERENCES TECHNICIEN(CodTech)
);

CREATE TABLE TACHE (
    CodTach  NVARCHAR(50) NOT NULL PRIMARY KEY,
    LibTach  NVARCHAR(50) NOT NULL,
    DureTheo NVARCHAR(50) NOT NULL,
    CodTech  NVARCHAR(50) NOT NULL REFERENCES TECHNICIEN(CodTech)
);

CREATE TABLE INTERVENTION (
    CodInterv NVARCHAR(50) NOT NULL PRIMARY KEY,
    TypInterv NVARCHAR(50) NOT NULL,
    DatInterv DATETIME     NOT NULL,
    NumGroup  NVARCHAR(50) NOT NULL REFERENCES GROUPE(NumGroup)
);

CREATE TABLE APPEL (
    NumAppel   INT          NOT NULL PRIMARY KEY,
    DatAppel   DATETIME     NOT NULL,
    HeureAppel TIME         NOT NULL,
    DureAppel  NVARCHAR(50) NOT NULL,
    CodTech    NVARCHAR(50) NOT NULL REFERENCES TECHNICIEN(CodTech),
    NumCli     NVARCHAR(50) NOT NULL REFERENCES CLIENT(NumCli)
);

CREATE TABLE MATERIEL (
    NumSerie NVARCHAR(50) NOT NULL PRIMARY KEY,
    NomMat   NVARCHAR(50) NOT NULL,
    Marque   NVARCHAR(50) NOT NULL,
    Model    NVARCHAR(50) NOT NULL,
    NumCli   NVARCHAR(50) NOT NULL REFERENCES CLIENT(NumCli)
);

CREATE TABLE VEHICULE (
    Immat    NVARCHAR(50) NOT NULL PRIMARY KEY,
    Nb_Place DECIMAL(5,0) NOT NULL
);

CREATE TABLE FICHE (
    NumFich  NVARCHAR(50) NOT NULL PRIMARY KEY,
    DatFich  DATETIME     NULL,
    NumSerie NVARCHAR(50) NULL REFERENCES MATERIEL(NumSerie),
    Immat    NVARCHAR(50) NULL REFERENCES VEHICULE(Immat)
);

CREATE TABLE FACTURER (
    NumFich  NVARCHAR(50) NOT NULL REFERENCES FICHE(NumFich),
    CoInterv NVARCHAR(50) NOT NULL REFERENCES INTERVENTION(CodInterv),
    CodTach  NVARCHAR(50) NOT NULL REFERENCES TACHE(CodTach),
    DatFact  DATETIME     NOT NULL,
    Dureff   NVARCHAR(50) NOT NULL,
    Montant  NVARCHAR(50) NOT NULL,
    PRIMARY KEY (NumFich, CoInterv, CodTach)
);

CREATE TABLE POSSEDER (
    CodInterv       NVARCHAR(50) NOT NULL REFERENCES INTERVENTION(CodInterv),
    NumCli          NVARCHAR(50) NOT NULL REFERENCES CLIENT(NumCli),
    PeriodeGarantie NVARCHAR(50) NOT NULL,
    PRIMARY KEY (CodInterv, NumCli)
);

CREATE TABLE UTILISATEUR (
    Login    NVARCHAR(50) NOT NULL,
    Motpasse NVARCHAR(50) NOT NULL,
    Nom      NVARCHAR(50) NOT NULL,
    Prenom   NVARCHAR(50) NOT NULL,
    Statut   NVARCHAR(50) NOT NULL,   -- "Administrateur" ou "Autres utilisateurs"
    PRIMARY KEY (Login, Motpasse)
);
GO

INSERT INTO UTILISATEUR VALUES ('admin', 'admin', 'Administrateur', 'Système', 'Administrateur');
INSERT INTO TECHNICIEN VALUES ('T001', 'DOSSOU', 'Marc');
INSERT INTO CLIENT VALUES ('C001', 'Société Alpha', 'Cotonou', 21300000, 'Entreprise', 'Siège');
GO
