using Oakton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OaktonParserTest
{
    public class Tests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 20)]
        [InlineData(1, -2)]
        [InlineData(1, -20)]
        [InlineData(-1, 2)]
        [InlineData(-1, -20)]
        [InlineData(-10, -20)]
        public void ShouldBeAbleToParseAllNumbersWithQuotes(int argVal, int optVal)
        {
            var cmd = $"my \"{argVal}\" --num \"{optVal}\"";

            var f = new CommandFactory();
            f.RegisterCommand<MyCommand>();
            
            var runner = f.BuildRun(cmd);

            var input = runner.Input as MyInput;
            Assert.NotNull(input); // If this is null, then things didn't parse properly

            Assert.Equal(argVal, input.ArgNum);
            Assert.Equal(optVal, input.NumFlag);
        }
    }
}