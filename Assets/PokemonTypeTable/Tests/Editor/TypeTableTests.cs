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
            var sut = new Water();
            var fire = new Fire();
            
            int result = sut.GetEffectivityAgainstFire();
            result.Should().Be(2);
        }
        [Test]
        public void Fire_Against_Water()
        {
            var sut = new Fire();
            var water = new Water();
            
            float result = sut.GetEffectivityAgainstWater();
            result.Should().Be(0.5f);
        }

        [Test]
        public void Water_Against_Water()
        {
            var sut = new Water();
            float result = sut.GetEffectivityAgainstWater();
            result.Should().Be(0.5f);
        }
        
        [Test]
        public void Fire_Against_Fire()
        {
            var sut = new Fire();
            float result = sut.GetEffectivityAgainstFire();
            result.Should().Be(0.5f);
        }
    }
}