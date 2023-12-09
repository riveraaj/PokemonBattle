using PokemonBattle.Models;
using System;

namespace PokemonBattle.Services {
    internal class TypeService {

        //Variable
        private const double ArenaModifier = 1.05; // 5% 

        //Function for calculating the damage adjusted between two types
        public double CalculateAdjustedDamage(double baseDamage, string attackerType1, string attackerType2, string defenderType1, string defenderType2) {
            //Verify the type relationship for both attacks
            double adjustedDamageType1 = CalculateAdjustedDamageForSingleType(baseDamage, attackerType1, defenderType1, defenderType2);
            double adjustedDamageType2 = CalculateAdjustedDamageForSingleType(baseDamage, attackerType2, defenderType1, defenderType2);

            //Return the lesser of the two adjusted damages
            return Math.Min(adjustedDamageType1, adjustedDamageType2);
        }

        //Function for calculating the damage adjusted for a single type
        private double CalculateAdjustedDamageForSingleType(double baseDamage, string attackerType, 
                                                            string defenderType1, string defenderType2) {
            //If the rates are the same, there is no adjustment
            if (attackerType == defenderType1 || attackerType == defenderType2) return baseDamage;

            double adjustmentFactor = 1.15; // Apply 15% adjustment

            //If the attacker is strong against the defender, adjust upward.
            if (IsStrongAgainst(attackerType, defenderType1, defenderType2)) return baseDamage * adjustmentFactor;

            //If the attacker is weak against the defender, adjust downward.
            else if (IsWeakAgainst(attackerType, defenderType1, defenderType2)) return baseDamage / adjustmentFactor;

            return baseDamage;  // If there is no adjustment, return base damage.
        }

        //Function to check if a type is strong against another type
        private bool IsStrongAgainst(string attackerType, string defenderType1, string defenderType2) => 
            IsStrongAgainstSingleType(attackerType, defenderType1) || IsStrongAgainstSingleType(attackerType, defenderType2);
        
        //Function to check if a type is strong against a single type
        public bool IsStrongAgainstSingleType(string attackerType, string defenderType) {
            switch (attackerType) {
                case "Fairy":
                    return defenderType == "Fight" || defenderType == "Dragon" || defenderType == "Dark";
                case "Steel":
                    return defenderType == "Ice" || defenderType == "Rock" || defenderType == "Fairy";
                case "Dark":
                    return defenderType == "Psychc" || defenderType == "Ghost";
                case "Dragon":
                    return defenderType == "Dragon";
                case "Ghost":
                    return defenderType == "Psychc" || defenderType == "Ghost";
                case "Rock":
                    return defenderType == "Fire" || defenderType == "Ice" || defenderType == "Flying" || defenderType == "Bug";
                case "Bug":
                    return defenderType == "Grass" || defenderType == "Psychc" || defenderType == "Dark";
                case "Psychc":
                    return defenderType == "Fight" || defenderType == "Poison";
                case "Flying":
                    return defenderType == "Grass" || defenderType == "Fight" || defenderType == "Bug";
                case "Ground":
                    return defenderType == "Fire" || defenderType == "Electr" || defenderType == "Poison" || defenderType == "Rock" || defenderType == "Steel";
                case "Poison":
                    return defenderType == "Grass" || defenderType == "Fairy";
                case "Fight":
                    return defenderType == "Normal" || defenderType == "Ice" || defenderType == "Rock" || defenderType == "Dark" || defenderType == "Steel";
                case "Ice":
                    return defenderType == "Grass" || defenderType == "Ground" || defenderType == "Flying" || defenderType == "Dragon";
                case "Grass":
                    return defenderType == "Water" || defenderType == "Ground" || defenderType == "Rock";
                case "Electr":
                    return defenderType == "Water" || defenderType == "Flying"; 
                case "Water":
                    return defenderType == "Fire" || defenderType == "Ground" || defenderType == "Rock";
                case "Fire":
                    return defenderType == "Grass" || defenderType == "Ice" || defenderType == "Bug" || defenderType == "Steel";
                default:
                    return false;
            }
        }

        //Function to check if a type is weak against another type
        private bool IsWeakAgainst(string attackerType, string defenderType1, string defenderType2) =>
            IsWeakAgainstSingleType(attackerType, defenderType1) || IsWeakAgainstSingleType(attackerType, defenderType2);

        //Function to check if a type is weak against a single type
        private bool IsWeakAgainstSingleType(string attackerType, string defenderType) {
            switch (attackerType) {
                case "Fairy":
                    return defenderType == "Steel" || defenderType == "Poison";
                case "Steel":
                    return defenderType == "Fire" || defenderType == "Fight" || defenderType == "Ground";
                case "Dark":
                    return defenderType == "Fight" || defenderType == "Bug" || defenderType == "Fairy";
                case "Dragon":
                    return defenderType == "Ice" || defenderType == "Dragon" || defenderType == "Fairy";
                case "Ghost":
                    return defenderType == "Ghost" || defenderType == "Dark";
                case "Rock":
                    return defenderType == "Water" || defenderType == "Grass" || defenderType == "Fight" || defenderType == "Ground" || defenderType == "Steel";
                case "Bug":
                    return defenderType == "Fire" || defenderType == "Flying" || defenderType == "Rock";
                case "Psychc":
                    return defenderType == "Bug" || defenderType == "Ghost" || defenderType == "Dark";
                case "Flying":
                    return defenderType == "Electr" || defenderType == "Ice" || defenderType == "Rock";
                case "Ground":
                    return defenderType == "Water" || defenderType == "Grass" || defenderType == "Ice";
                case "Poison":
                    return defenderType == "Ground" || defenderType == "Psychc";
                case "Fight":
                    return defenderType == "Flying" || defenderType == "Psychc" || defenderType == "Fairy";
                case "Ice":
                    return defenderType == "Fire" || defenderType == "Fight" || defenderType == "Rock" || defenderType == "Steel";
                case "Grass":
                    return defenderType == "Fire" || defenderType == "Ice" || defenderType == "Poison" || defenderType == "Flying" || defenderType == "Bug";
                case "Electr":
                    return defenderType == "Ground";
                case "Water":
                    return defenderType == "Electr" || defenderType == "Grass";
                case "Fire":
                    return defenderType == "Water" || defenderType == "Ground" || defenderType == "Rock";
                case "Normal":
                    return defenderType == "Fight";
                default:
                    return false;
            }
        }

        //Function to obtain the types of elements that the pokemon that is fighting has for the defender.
        public (string defenderType1, string defenderType2) GetTypesOfDefender(int currentPokemon, Player oPlayer) {
            string defenderType1 = "", defenderType2 = "";

            switch (currentPokemon) {
                case 0:
                    defenderType1 = oPlayer.Team.PokemonOne.TypeElementOne.TypeElementName;
                    defenderType2 = oPlayer.Team.PokemonOne.TypeElementTwo?.TypeElementName;
                    break;
                case 1:
                    defenderType1 = oPlayer.Team.PokemonTwo.TypeElementOne.TypeElementName;
                    defenderType2 = oPlayer.Team.PokemonTwo.TypeElementTwo?.TypeElementName;
                    break;
                case 2:
                    defenderType1 = oPlayer.Team.PokemonThree.TypeElementOne.TypeElementName;
                    defenderType2 = oPlayer.Team.PokemonThree.TypeElementTwo?.TypeElementName;
                    break;
                case 3:
                    defenderType1 = oPlayer.Team.PokemonFour.TypeElementOne.TypeElementName;
                    defenderType2 = oPlayer.Team.PokemonFour.TypeElementTwo?.TypeElementName;
                    break;
                case 4:
                    defenderType1 = oPlayer.Team.PokemonFive.TypeElementOne.TypeElementName;
                    defenderType2 = oPlayer.Team.PokemonFive.TypeElementTwo?.TypeElementName;
                    break;
                case 5:
                    defenderType1 = oPlayer.Team.PokemonSix.TypeElementOne.TypeElementName;
                    defenderType2 = oPlayer.Team.PokemonSix.TypeElementTwo?.TypeElementName;
                    break;
            }
            return (defenderType1, defenderType2);
        }

        //Function to obtain the types of elements that the pokemon that is fighting has for the attacker.
        public (string attackerType1, string attackerType2) GetTypesOfAttacker(int currentPokemon, Player oPlayer) {
            string attackerType1 = "", attackerType2 = "";

            switch (currentPokemon)
            {
                case 0:
                    attackerType1 = oPlayer.Team.PokemonOne.TypeElementOne.TypeElementName;
                    attackerType2 = oPlayer.Team.PokemonOne.TypeElementTwo?.TypeElementName;
                    break;
                case 1:
                    attackerType1 = oPlayer.Team.PokemonTwo.TypeElementOne.TypeElementName;
                    attackerType2 = oPlayer.Team.PokemonTwo.TypeElementTwo?.TypeElementName;
                    break;
                case 2:
                    attackerType1 = oPlayer.Team.PokemonThree.TypeElementOne.TypeElementName;
                    attackerType2 = oPlayer.Team.PokemonThree.TypeElementTwo?.TypeElementName;
                    break;
                case 3:
                    attackerType1 = oPlayer.Team.PokemonFour.TypeElementOne.TypeElementName;
                    attackerType2 = oPlayer.Team.PokemonFour.TypeElementTwo?.TypeElementName;
                    break;
                case 4:
                    attackerType1 = oPlayer.Team.PokemonFive.TypeElementOne.TypeElementName;
                    attackerType2 = oPlayer.Team.PokemonFive.TypeElementTwo?.TypeElementName;
                    break;
                case 5:
                    attackerType1 = oPlayer.Team.PokemonSix.TypeElementOne.TypeElementName;
                    attackerType2 = oPlayer.Team.PokemonSix.TypeElementTwo?.TypeElementName;
                    break;
            }
            return (attackerType1, attackerType2);
        }

        public double CalculateArenaTypeModifier(string arenaType, string pokemonType) {
            if (arenaType == pokemonType) return 1;
            else if (IsStrongAgainstSingleType(arenaType, pokemonType)) return ArenaModifier;
            else return -ArenaModifier;
        }
    }
}