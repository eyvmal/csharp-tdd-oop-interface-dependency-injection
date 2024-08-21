using NUnit.Framework;
using tdd_oop_interface_dependency_injection.CSharp.Main;

namespace csharp_tdd_oop_interface_dependency_injection.Tests
{
        [TestFixture]
        public class ScrabbleTest {
        [Test]
        public void ShouldGive0ForEmptyWords() {
            var scrabble = new Scrabble(new EnglishAlphabet());
            Assert.That(scrabble.Score(""), Is.EqualTo(0));
        }

        [Test]
        public void ShouldGive0ForWhiteSpace() {
            var scrabble = new Scrabble(new EnglishAlphabet());
            Assert.That(scrabble.Score("\n\r\t\b\f"), Is.EqualTo(0));
        }

        [Test]
        public void ShouldScore1ForA() {
            var scrabble = new Scrabble(new EnglishAlphabet());
            Assert.That(scrabble.Score("a"), Is.EqualTo(1));
        }

        [Test]
        public void ShouldScore4ForF() {
            var scrabble = new Scrabble(new EnglishAlphabet());
            Assert.That(scrabble.Score("f"), Is.EqualTo(4));
        }

        [Test]
        public void ShouldScore6ForStreet() {
            var scrabble = new Scrabble(new EnglishAlphabet());
            Assert.That(scrabble.Score("street"), Is.EqualTo(6));
        }

        [Test]
        public void ShouldScore22ForQuirky() {
            var scrabble = new Scrabble(new EnglishAlphabet());
            Assert.That(scrabble.Score("quirky"), Is.EqualTo(22));
        }

        [Test]
        public void ShouldScoreRussianLetters() {
            var scrabble = new Scrabble(new RussianAlphabet());
            Assert.That(scrabble.Score("дврфъ"), Is.EqualTo(18));
        }

        [Test]
        public void ShouldScoreGreekLetters() {
            var scrabble = new Scrabble(new GreekAlphabet());
            Assert.That(scrabble.Score("φεψωλ"), Is.EqualTo(20));
        }
    }
}