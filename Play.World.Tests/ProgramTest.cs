using System;
using System.IO;
using System.Text;
using Play.World;
using Moq;
using Xunit;

namespace Play.World.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void Test1()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("Hello");
            Console.SetIn(input);

            var expected = string.Format("What's your name?{0}Hello Somebody!!{0}", Environment.NewLine);

            var args = new string[] { "arg1", "arg2", "arg3" };

            AssertAsync.CompletesIn(2, () =>
            {
                Play.World.Program.Main(args);
            });

            Assert.Equal(expected, output.ToString());
        }
    }
}
