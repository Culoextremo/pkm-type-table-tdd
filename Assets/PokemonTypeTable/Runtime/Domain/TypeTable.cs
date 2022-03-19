namespace PokemonTypeTable.Runtime.Domain
{
    public class TypeTable
    {
        public float GetEffectivityAgainst(PokemonType pokemonType)
        {
            switch (pokemonType)
            {
                case PokemonType.Fire:
                    return 2;
                case PokemonType.Water:
                    return 0.5f;
            }
            return -1;
        }
    }
}