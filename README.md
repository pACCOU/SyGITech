# SyGITech — Système de Gestion des Interventions Techniques

Application Windows (VB.NET / WinForms, .NET Framework 3.5) pour une société de
maintenance : clients, matériel, techniciens et groupes, interventions,
fiches, facturation et périodes de garantie, avec éditions Crystal Reports.

> **English** — Field-service management desktop app (VB.NET WinForms, SQL
> Server). Clients, equipment, technicians, interventions, invoicing and
> warranty periods, with Crystal Reports printouts. 2020 academic project,
> cleaned up in 2026 (config-based connection string, parameterized login,
> full SQL schema script).

![VB.NET](https://img.shields.io/badge/VB.NET-WinForms-5C2D91)
![.NET Framework 3.5](https://img.shields.io/badge/.NET%20Framework-3.5-512BD4)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927)
![Licence MIT](https://img.shields.io/badge/licence-MIT-green)

## Fonctionnalités

- Référentiels : clients, matériel (par client), techniciens, groupes de techniciens, tâches, véhicules
- Appels clients et interventions (type, date, groupe affecté)
- Fiches d'intervention et facturation (durée effective, montant)
- Périodes de garantie par client et intervention
- Utilisateurs avec deux profils (administrateur / autres utilisateurs), changement de mot de passe
- États imprimables (Crystal Reports) : liste des appels par client, factures, périodes de garantie

## Installation

Prérequis : Windows, Visual Studio (2019 ou 2022) avec **.NET Framework 3.5**
activé dans les fonctionnalités Windows, SQL Server Express ou LocalDB, et
[SAP Crystal Reports runtime for Visual Studio](https://www.sap.com/products/technology-platform/crystal-reports.html)
(version 13) pour les états.

```powershell
git clone https://github.com/pACCOU/SyGITech.git
cd SyGITech
sqlcmd -S .\SQLEXPRESS -i database\intervention.sql      # base + utilisateur admin/admin
```

Ouvrir `SyGITech.sln`, adapter si besoin la chaîne de connexion dans
`SyGITech/app.config` (clé `interventionConnectionString`, par défaut
`.\SQLEXPRESS`), puis F5.

## Schéma de la base

Reconstruit depuis le DataSet typé de l'application (clés primaires et
relations incluses) — [`database/intervention.sql`](database/intervention.sql).

```
TECHNICIEN ─┬─< GROUPE ─< INTERVENTION ─┬─< POSSEDER >─ CLIENT ─< MATERIEL ─< FICHE >─ VEHICULE
            ├─< TACHE  ─────────────────┴─< FACTURER >─┘
            └─< APPEL >─ CLIENT
UTILISATEUR (Login, Motpasse, Nom, Prenom, Statu)
```

## Historique

**2026 — remise en état** : chaîne de connexion lue dans `app.config` (elle
visait le poste `KJEC-PC` en dur), requête de connexion paramétrée, script
SQL complet, `.gitignore`, licence.

**2020 — version initiale** (projet de fin de formation).

## Limites connues

- Mots de passe en clair dans `UTILISATEUR` ; la clé primaire composite (Login, Motpasse) est un choix d'époque à revoir.
- Les autres formulaires construisent encore leurs requêtes par concaténation (apostrophes échappées par `recup()`), à migrer vers des paramètres.
- Crystal Reports est propriétaire : pour une version moderne, remplacer par des rapports RDLC ou une génération PDF.

Licence MIT — Florian Whannou
