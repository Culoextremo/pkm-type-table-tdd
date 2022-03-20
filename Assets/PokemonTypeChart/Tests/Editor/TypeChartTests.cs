using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using PokemonTypeTable.Runtime.Domain;

namespace PokemonTypeTable.Tests.Editor
{
    public class TypeChartTests
    {
        [Test]
        [TestCase(PokemonType.Water, PokemonType.Fire, 2f)]
        [TestCase(PokemonType.Water, PokemonType.Water, .5f)]
        [TestCase(PokemonType.Fire, PokemonType.Water, .5f)]
        [TestCase(PokemonType.Fire, PokemonType.Fire, .5f)]
        public void Effectiveness_AttackingType_To_DefendingType_Is_Correct(PokemonType attackingType, PokemonType defendingType, float expectedResult)
        {
            var sut = BuildDefaultTypeChart();

            float result = sut.GetEffectivenessAgainst(attackingType, defendingType);

            result.Should().Be(expectedResult);
        }

        [Test]
        public void Invalid_Dictionary_Throws_Exception()
        {
            Func<TypeChart> sut = () => new TypeChart(null);
        
            sut.Should().ThrowExactly<ArgumentNullException>();
        }

        private TypeChart BuildDefaultTypeChart()
        {
            var fireEffectiveness = new Dictionary<PokemonType, float>()
            {
                {PokemonType.Fire, 0.5f},
                {PokemonType.Water, 0.5f}
            };
            var waterEffectiveness = new Dictionary<PokemonType, float>()
            {
                {PokemonType.Fire, 2f},
                {PokemonType.Water, 0.5f}
            };
            var effectiveness = new Dictionary<PokemonType, Dictionary<PokemonType, float>>
            {
                {PokemonType.Fire, fireEffectiveness},
                {PokemonType.Water, waterEffectiveness}
            };
            return new TypeChart(effectiveness);
        }
    }
}