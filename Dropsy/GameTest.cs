﻿using System;
using NUnit.Framework;

namespace Dropsy
{
    [TestFixture]
    public class GameTest
    {
        [Test]
        public void Construction()
        {
            var testObj = new Game(1);
            Assert.That(testObj, Is.Not.Null);
        }

        [Test]
        public void PlayShouldPlayTheGame()
        {
            var testObj = new Game(1);
            var screen = new FakeScreen();
            testObj.Screen = screen;
            testObj.Play();
            Assert.That(screen.output, Is.EqualTo(
                "┌───┐\n"+
                "│   │\n"+
                "└───┘\n"));
        }


    }

    public class FakeScreen : IScreen
    {
        public string output = "";
        public void WriteLine(string line)
        {
            output += line + "\n";
        }
    }
}