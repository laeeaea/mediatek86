# mediatek86
Outil de gestion de personnel et d'absences de la médiathèque

## Pre-requis

Ce programme requiert l'installation de MySQL v9.3 pour fonctionner. L'application utilise une connexion avec l'utilisateur suivant :
```
root@'localhost'
PASSWORD=NO
```

Il est necessaire, une fois MySQL installe, de creer la base a l'aide du script [Database/create_database.sql](https://github.com/laeeaea/mediatek86/blob/main/Database/create_database.sql)

## Installation

L'installateur executable est disponible dans [SetupMediaTek86/Release/SetupMediaTek86.msi](https://github.com/laeeaea/mediatek86/blob/main/SetupMediaTek86/Release/SetupMediaTek86.msi)
Il est possible de charger la solution complète avec le code source dans Visual Studio (tests effectues avec VS 2022) en chargeant le fichier Solution MediaTek86.sln.

## Utilisation

L'application se presente sous la forme d'un ecran de connexion puis d'un gestionnaire de personnel (liste/ajout/modification/suppression)
Le compte responsable preconfigure est:
```
Login: admin
Password: MdpAdmin
```
Une video de presentation est disponible dans [Video/Demo_Video_MediaTek86.mkv](https://github.com/laeeaea/mediatek86/blob/main/Video/Demo_Video_MediaTek86.mkv)

## Limitations

Les fonctions de gestion des absences n'ont pas été implémentés (vues formulaires uniquement)
