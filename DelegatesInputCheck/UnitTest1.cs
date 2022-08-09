using Delegates;
using System;
using System.IO;
using Xunit;

namespace DelegatesInputCheck
{
    public class UnitTest1
    {
        ConsoleReader check = new ConsoleReader();
        [Fact]
        public void tringCheck()
        {
            var input = new StringReader("Somebody");
            Console.SetIn(input);
            Assert.Equal("OnWord", check.Run());


        }
        [Fact]
        public void junkCheck()
        {
            var input = new StringReader("@Somebody");
            Console.SetIn(input);
            Assert.Equal("OnJunk", check.Run());


        }
        [Fact]
        public void numberCheck()
        {
            var input = new StringReader("123");
            Console.SetIn(input);
            Assert.Equal("OnNumber", check.Run());

        }
        [Fact]
        public void numberAndWord()
        {
            var input = new StringReader("ABC123");
            Console.SetIn(input);
            Assert.Equal("OnWord", check.Run());

        }
        [Fact]
        public void whiteSPace()
        {
            var input = new StringReader(" ");
            Console.SetIn(input);
            Assert.Equal("OnJunk", check.Run());

        }
        [Fact]
        public void NumberandWordcheck()
        {
            var input = new StringReader("ABC123");
            Console.SetIn(input);
            Assert.NotEqual("OnJunk", check.Run());

        }

    }
}
