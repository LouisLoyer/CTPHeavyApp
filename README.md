# Gestionnaire de Comptes CesiTonPlat

## À propos du projet

Ce projet est un gestionnaire de base de données écrit en C# destiné à la création et à la gestion des comptes utilisateur pour l'application Vue.JS *CesiTonPlat*, une réplique de Uber. Les deux applications communiquent via une API REST, facilitant ainsi la synchronisation et la gestion des données utilisateurs entre le frontend Vue.JS et le backend C#.

## Fonctionnalités

- **Création de comptes utilisateur :** Permet aux nouveaux utilisateurs de créer un compte pour accéder à l'application *CesiTonPlat*.
- **Gestion des comptes utilisateur :** Offre aux administrateurs la possibilité de gérer les comptes (activation, désactivation, modification).
- **Sécurisation des données :** Utilise des méthodes de chiffrement pour sécuriser les informations des utilisateurs.
- **Communication API :** Interface API pour une communication fluide entre le gestionnaire de comptes et l'application *CesiTonPlat*.

## Prérequis

Avant de débuter, assurez-vous d'avoir installé les éléments suivants :

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version compatible avec le projet)
- [Node.js et npm](https://nodejs.org/) (pour l'application Vue.JS *CesiTonPlat*)

## Installation

1. **Clonez le dépôt :**

```bash
git clone https://github.com/votre-username/gestionnaire-comptes-cesitonplat.git
cd gestionnaire-comptes-cesitonplat
