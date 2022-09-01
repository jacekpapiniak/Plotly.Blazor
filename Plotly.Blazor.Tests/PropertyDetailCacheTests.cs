using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using FluentAssertions;
using NUnit.Framework;

namespace Plotly.Blazor.Tests
{   
    [TestFixture]
    public class PropertyDetailCacheTests
    {
        [Test]
        public void GetPropertyDetails_GivenTypeWithSubplotProperty_ReturnsSubPlotProperty()
        {
            var properties = PropertyDetailCache.GetPropertyDetails(typeof(TestSubplotClass));

            properties.Count(p => p.Property.Name == nameof(TestSubplotClass.Items) && p.NameAttributeValue == null 
                && p.ContainsSubPlot && !p.ContainsArray).Should().Be(1);
        }
        
        [Test]
        public void GetPropertyDetails_GivenTypeWithArrayProperty_ReturnsArrayProperty()
        {
            var properties = PropertyDetailCache.GetPropertyDetails(typeof(TestSubplotClass));

            properties.Count(p => p.Property.Name == nameof(TestSubplotClass.TestPropertyArray) && p.NameAttributeValue == "testProperty" 
                && !p.ContainsSubPlot && p.ContainsArray).Should().Be(1);
        }
        
        [Test]
        public void GetPropertyDetails_GivenMultipleCallsWithSameType_ReturnsCachedProperties()
        {
            var properties1 = PropertyDetailCache.GetPropertyDetails(typeof(TestSubplotClass));
            var properties2 = PropertyDetailCache.GetPropertyDetails(typeof(TestSubplotClass));
            properties1.Should().BeSameAs(properties2);
        }
    }
}