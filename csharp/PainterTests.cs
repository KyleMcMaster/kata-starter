using System;
using AutoFixture.Idioms;
using FluentAssertions;
using Kata.Starter.Fixtures;
using Xunit;

namespace Kata.Starter
{
    public class PainterTests
    {
        [Theory, AutoDomainData]
        public void Constructor_Inefficiently_Guards_Against_Null_Parameters(
            string firstName,
            string lastName,
            string socialSecurityNumber)
        {
            var nullFirstNameAction = () => new Painter(
                firstName: null,
                lastName: lastName,
                socialSecurityNumber: socialSecurityNumber);

            var nullLastNameAction = () => new Painter(
                firstName: firstName,
                lastName: null,
                socialSecurityNumber: socialSecurityNumber);

            var nullSocialSecurityNumberAction = () => new Painter(
                firstName: firstName,
                lastName: lastName,
                socialSecurityNumber: null);

            nullFirstNameAction.Should().Throw<ArgumentNullException>();
            nullLastNameAction.Should().Throw<ArgumentNullException>();
            nullSocialSecurityNumberAction.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void Constructor_Guards_Against_Null_Parameters()
        {
            var fixture = new DomainFixture();
            var assertion = new GuardClauseAssertion(fixture);
            assertion.Verify(typeof(Painter).GetConstructors());
        }

        [Fact]
        public void Methods_Guards_Against_Null_Parameters()
        {
            var fixture = new DomainFixture();
            var assertion = new GuardClauseAssertion(fixture);
            assertion.Verify(typeof(Painter).GetMethods());
        }
    }
}
