# Rubik's Cube

Petit projet réalisé en C# dans le cadre de mon BTS informatique.

Cette application console permet de manipuler un Rubik's Cube 3 × 3, d'afficher ses faces et de mélanger le cube.

## Fonctionnalités

- Affichage du cube en couleurs dans la console.
- Rotation des six faces.
- Mélange aléatoire du cube.
- Réinitialisation du cube.

## Technologies

- C#
- .NET 11

## Lancer le projet

Cloner le dépôt :

```bash
git clone https://github.com/yalac/RubiksCube.git
cd RubiksCube
```

Lancer l'application :

```bash
dotnet run --project RubiksCube/RubiksCube.csproj
```

## Commandes

| Touche | Action |
|---|---|
| `F`, `B`, `R`, `L`, `U`, `D` | Tourner une face |
| `Maj` + une touche de mouvement | Effectuer le mouvement inverse |
| `P` | Mélanger le cube |
| `Maj` + `P` | Annuler le dernier mélange |
| `N` | Réinitialiser le cube |
| `Échap` | Quitter |
