using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

//First()
// FirstOrDefault()
// Single()
// SingleOrDefault()
// Any()
// Select()
// Where()
// OrderBy()
// OrderByDescending()
// ToList
//Skip
//Take
//Wlasne metody
namespace Linq
{
    public class TestIEnumerable
    {
        private readonly IEnumerable<int> _numberList = new[] { 1, 2, 3, 4, 5, 6, 7, };
        private readonly IEnumerable<string> _nameList = new[] { "Alicja", "Tomasz", "Ewa", "Adam", "Jakub", "Jarek" };

        [Fact]
        public void TestWhere()
        {

            var shortNames = _nameList.Where(x => x.Length <= 5);

            var shortNames2 = from n in _nameList where n.Length <= 5 select n;
            
            var expected = new[] { "Ewa", "Adam", "Jakub", "Jarek" };

            Assert.Equal(expected, shortNames);
        }

        [Fact]
        public void TestSum()
        {
            var sum = _numberList.Sum();
            var extendedSum = _numberList.Sum(x => x + 1);

            Assert.True(true);
        }

        [Fact]
        public void TestJoinString()
        {
            // var agg = _nameList.Sum(x => x.Length);
            var agg2 = _nameList.Aggregate("", (s, s1) => s + s1);


            Assert.True(true);
        }


        [Fact]
        public void TestSelect()
        {
            var test = _numberList.Select(x => new
            {
                Name = x
            });
            
            Assert.True(true);
        }
        
        [Fact]
        public void Playground()
        {
            Assert.True(true);
        }
        
    }
}