using FluentAssertions;
using NUnit.Framework;
using PokemonTypeTable.Runtime.Domain;

namespace PokemonTypeTable.Tests.Editor
{
    public class TypeTableTests
    {
        [Test]
        public void Water_Against_Fire()
        {
            var sut = new TypeTable(GetDefaultTypeEffectivities());
            
            float result = sut.GetEffectivityAgainst(PokemonType.Water, PokemonType.Fire);
            
            result.Should().Be(2);
        }
        
        [Test]
        public void Fire_Against_Water()
        {
            var sut = new TypeTable(GetDefaultTypeEffectivities());
            
            float result = sut.GetEffectivityAgainst(PokemonType.Fire, PokemonType.Water);
            
            result.Should().Be(0.5f);
        }

        [Test]
        public void Water_Against_Water()
        {
            var sut = new TypeTable(GetDefaultTypeEffectivities());
            
            float result = sut.GetEffectivityAgainst(PokemonType.Water, PokemonType.Water);
            
            result.Should().Be(0.5f);
        }
        [Test]
        public void Fire_Against_Fire()
        {
            var sut = new TypeTable(GetDefaultTypeEffectivities());
            
            float result = sut.GetEffectivityAgainst(PokemonType.Fire, PokemonType.Fire);
            
            result.Should().Be(0.5f);
        }

        private float[,] GetDefaultTypeEffectivities()
        {
            return new float[,]
            {//         WATER  FIRE
             /*Fire*/   {0.5f, 0.5f},
             /*Water*/  {2f,   0.5f}
            };
        }
    }
}