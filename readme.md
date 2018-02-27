Dans Isen.DotNet.ConsoleApp : `dotnet new console`
Dans Isen.DotNet.ConsoleApp : `dotnet run`

## Commit Git
Etat des fichiers (non tracké): `git status`
Tracker les fichiers: `git add .`
Ils sont mintenant suivis 
Commit : `git commit -m "Initial commit"`
Prendre en compte les modiffs (**mais pas les ajouts de fichiers**) au moment du commit
Donc faire un add et un commit en même temps
Update : `git commit -a -m "updated readme"`
Dans Isen.DotNet.Library : `dotnet new classlib`

## Ajout de la librairie en référence au projet console 
Depuis Isen.DotNet.ConsoleApp
Isen.DotNet\Isen.DotNet.ConsoleApp> `dotnet add reference ..\Isen.DotNet.Library\Isen.DotNet.Library.csproj `

## Création d'une solution et ajout dans le projet
Depuis le dossier racine
Creer le fichier de solution : `dotnet new sln`
Ajouter le projet librairie : `dotnet sln add`
 `dotnet sln add .\Isen.DotNet.Library\Isen.DotNet.Library.csproj`

Ajouter le projet librairie : dotnet sln add
  `dotnet sln add .\Isen.DotNet.ConsoleApp\Isen.DotNet.ConsoleApp.csproj `

Commit git:
`git add .`
`git commit -m "Console, lib, solution"`

## Ajouter un projet de test
TDD = Test Driven Developpement 
`mkdir  Isen.DotNet.Tests`
`dotnet new xunit`

Depuis dossier de solution: `dotnet sln add .\Isen.DotNet.Tests\Isen.DotNet.Tests.csproj `

Depuis dossier de Tests: `dotnet add reference .\Isen.DotNet.Library\Isen.DotNet.Library.csproj `
