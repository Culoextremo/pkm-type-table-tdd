namespace PokemonTypeTable.Runtime.Domain
{
    public class TypeTable
    {
        private float[,] typeEffectivities;
        public TypeTable(float[,] typeEffectivities)
        {
            this.typeEffectivities = typeEffectivities;
        }
        public float GetEffectivityAgainst(PokemonType from, PokemonType to)
        {
            return typeEffectivities[(int) from, (int) to];
        }
    }
}