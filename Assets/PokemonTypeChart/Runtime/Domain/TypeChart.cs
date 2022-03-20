using System;
using System.Collections.Generic;

namespace PokemonTypeTable.Runtime.Domain
{
    public class TypeChart
    {
        private readonly Dictionary<PokemonType, Dictionary<PokemonType, float>> typeEffectiveness;
        public TypeChart(Dictionary<PokemonType, Dictionary<PokemonType, float>> typeEffectiveness)
        {
            if (typeEffectiveness == null)
            {
                throw new ArgumentNullException($"{nameof(TypeChart)} can not be build with a null {nameof(typeEffectiveness)}...");
            }
            
            this.typeEffectiveness = typeEffectiveness;
        }
        public float GetEffectivenessAgainst(PokemonType attackingType, PokemonType defendingType)
        {
            return typeEffectiveness[attackingType][defendingType];
        }
    }
}