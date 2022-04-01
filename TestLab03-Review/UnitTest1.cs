using System;
using Xunit;
using Lab03_Review;

namespace TestLab03_Review
{
    public class UnitTest1
    {
        [Fact]
        public void TestChallenge1()
        {
            Assert.Equal( 8 , Program.Challenge1Method("2 2 2"));
            Assert.Equal(24 , Program.Challenge1Method("2 3 4 5"));
            Assert.Equal(0 , Program.Challenge1Method("3 6"));
            Assert.Equal(-24 , Program.Challenge1Method("-2 3 4"));
        }

        [Fact]
        public void TestChallenge2()
        {
            Assert.Equal(2, Program.Challenge2Method(new int[] { 1, 2, 3, 4 }, 4));
            Assert.Equal(3, Program.Challenge2Method(new int[] { 4, 2, 3 }, 3));
            Assert.Equal(0, Program.Challenge2Method(new int[] { 0, 0, 0, 0 }, 4));
        }

        [Fact]
        public void TestChallenge4()
        {
            Assert.Equal(1, Program.Challenge4(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }));
            Assert.Equal(2, Program.Challenge4(new int[] { 1, 2, 3, 4, 2, 2 }));
            Assert.Equal(2, Program.Challenge4(new int[] { 2, 2, 2, 2 }));
            Assert.Equal(1, Program.Challenge4(new int[] { 1, 2, 3, 4 }));
            Assert.Equal(4, Program.Challenge4(new int[] { 4, 2, 4, 2 }));
        }

        [Fact]
        public void TestChallenge5()
        {
            Assert.Equal(-1, Program.Challenge5(new int[] { -2, -5, -22, -1, -9, -3 }));
            Assert.Equal(2, Program.Challenge5(new int[] { 2, 2, 2, 2, 2, 2 }));
        }

        [Fact]
        public void TestChallenge9()
        { 
        
        }
    }
}
