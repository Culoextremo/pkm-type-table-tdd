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
            var sut = new TypeTable();
            
            float result = sut.GetEffectivityAgainst(PokemonType.Fire);
            
            result.Should().Be(2);
        }
        
        [Test]
        public void Fire_Against_Water()
        {
            var sut = new TypeTable();
            
            float result = sut.GetEffectivityAgainst(PokemonType.Water);
            
            result.Should().Be(0.5f);
        }

        [Test]
        public void Water_Against_Water()
        {
            var sut = new TypeTable();
            
            float result = sut.GetEffectivityAgainst(PokemonType.Water);
            
            result.Should().Be(0.5f);
        }
    }
}