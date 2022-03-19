namespace PokemonTypeTable.Runtime.Domain
{
    public class PokemonType
    {
        public int GetEffectivityAgainstFire()
        {
            return 2;
        }

        public float GetEffectivityAgainstWater()
        {
            return 0.5f;
        }
    }
}