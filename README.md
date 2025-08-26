# StudentRegistry

StudentRegistry est une application web ASP.NET Core Razor Pages permettant de gérer un registre d’étudiants.

## Fonctionnalités

- Ajouter, modifier, supprimer et lister des étudiants
- Rechercher des étudiants par nom ou email
- Validation des formulaires côté client et serveur
- Interface utilisateur moderne avec Bootstrap

## Technologies utilisées

- .NET 8
- ASP.NET Core Razor Pages
- Entity Framework Core (SQL Server)
- Bootstrap
- jQuery Validation

## Structure du projet

- `Models/Student.cs` : Modèle de données étudiant
- `Controllers/StudentController.cs` : Contrôleur pour la gestion des étudiants
- `Views/Student/Index.cshtml` : Liste et recherche des étudiants
- `Views/Student/Create.cshtml` : Ajout d’un étudiant
- `Views/Student/Edit.cshtml` : Modification d’un étudiant
- `Views/Student/Delete.cshtml` : Suppression d’un étudiant
- `Data/ApplicationDbContext.cs` : Contexte de base de données

## Prérequis

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server (ou modifiez la chaîne de connexion dans `appsettings.json`)
- Visual Studio 2022 ou VS Code

## Installation et utilisation

1. **Cloner le dépôt**

2. **Restaurer les packages**


3. **Configurer la base de données**
- Modifier la chaîne de connexion dans `appsettings.json` si besoin.

4. **Appliquer les migrations et créer la base**


5. **Lancer l’application**

## Licence

Ce projet est sous licence MIT.

---

N’hésite pas à adapter ce fichier selon tes besoi
