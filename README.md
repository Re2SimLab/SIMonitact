# SIMonitact
SIMonitact est une application  pour le monitoring de l'activité d'un centre de formation.
SIMonitact est une application Windows (VB .NET) pour le monitoring de l’activité d'un centre de formation. Elle permet de sauvegarder des formations faites avec le centre dans une base de données (BDD) Access chiffrée. Les formations enregistrées dans la base de données (SIMonitactBDD.accdb) peuvent être modifiées ou supprimées grâce à l’application. Les données de la DBB peuvent être extraites à tout moment via l’application afin d’analyser l’activité du centre, des formateurs, des aides-formateurs ou des participants. Enfin, SIMonitact permet de générer des bilans d’activité sur une période donnée.

## Installation
### Prérequis
La base de données de SIMonitact est une base Microsoft Access 2013. Le logiciel peut être téléchargé ici : https://www.microsoft.com/fr-FR/download/details.aspx?id=39358

### Téléchargement de SIMonitact
SIMonitact est en accès libre sur Github sous licence GPL-3. 
Lien de téléchargement de l’application : https://github.com/Re2SimLab/SIMonitact
Télécharger le .ZIP du répertoire et décompresser le dossier.

## Premier lancement de SIMonitact 
### Avant de démarrer
Avant de lancer SIMonitact, effectuer les étapes suivantes :
*	Placer le dossier déziper de SIMonitact sur votre disque dur dans C:\Program Files
**	Cette étape permet de garder l’application et le code source en lieu sûr et de pouvoir la récupérer plus tard en cas de besoin
*	Dans un dossier de votre choix (dossier d’utilisation de SIMonitact), copier/coller la base de données (SIMonitactBDD.accdb) qui se trouve dans le dossier C:\Program Files\SIMonitact\SIMonitact.
**	La base de données SIMonitactBDD.accdb est indispensable pour que l’application fonctionne
*	Toujours dans le dossier C:\Program Files\SIMonitact\SIMonitact, cliquer droit sur l’application SIMonitact puis Créer un raccourci. Copier le raccourci de l'application dans votre dossier (dossier d’utilisation) et renommer le SIMonitact.
**	Créer un raccourci de l’application permet de d’assurer de toujours avoir l’application originale en cas de suppression inopinée…
L’application SIMonitact est prête à être lancée !
  
### Première utilisation de SIMonitact
Lancer l’application via le raccourci créé dans votre dossier d’utilisation.
Une fois SIMonitact lancée, cliquez sur les paramètres de l’application en bas à droite.
Dans les paramètres de l’application, cliquez sur les différents dossiers afin de définir les chemins d’accès aux bases de données et aux fichiers d’extractions.
* Le prmier dossier défini le chemin d’accès à la base de données SIMonitactBDD.accdb. Sélectionner votre dossier d’utilisation de l’application.
* Le deuxième dossier	défini le chemin de la backup de la base de données. Sélectionner le dossier de votre choix. Le plus sûr étant de laisser le chemin par défaut ou de sélectionner le dossier source de l’application C:\Program Files\SIMonitact\SIMonitact
* Le troisième dossier défini où placer les fichiers d’extraction de la base de données. Sélectionner le dossier de votre choix. Il est recommandé de sélectionner votre dossier d’utilisation de l’application  pour retrouver les fichiers facilement.
*	Cliquer sur ‘Sauvegarder les paramètres’ pour valider les changements effectués.

NB : Ne pas changer le mot de passe d’accès à la BDD (mot de passe par défaut). Pour changer ce mot de passe, se référer au guide d’utilisation de SIMonitact.

**Vous pouvez maintenant utiliser SIMonitact !!**

Laissez-vous guider ou consulter le guide d’utilisation de SIMonitact pour prendre l’application en main !


## Développement de l’application
Monitact a été développé en Visual Basic .NET (VB .NET) à l’aide du logiciel Visual Studio 2019 (Miscrosoft).
Pour modifier l’application, télécharger Visual Studio Community : https://visualstudio.microsoft.com/fr/downloads/?rr=https%3A%2F%2Fwww.google.com%2F
Une fois le logiciel téléchargé, aller dans le dossier « C:\Program Files\SIMonitact\Code source »
Lancer le projet « SIMonitact.sln ». 
Apporter les modifications souhaitées. Les tester en exécutant le code en mode « Debug ». 
Une fois que tout est ok, exécuter le code en mode « Release ». Récupérer l’exécutable intitulé « SIMonitact.exe » dans le dossier « C:\Program Files\SIMonitact\Code source\SIMonitact\bin\Release ». 
Placer cette nouvelle version dans le dossier « C:\Program Files\SIMonitact\SIMonitact ». 
Cliquer droit sur l’application et Créer un raccourci. Copier le raccourci de l'application dans votre dossier d’utilisation et renommer le SIMonitact.
Effectuer les étapes décrite dans la section « Premier lancement de SIMonitact» et l’application est prête à être utilisée.
