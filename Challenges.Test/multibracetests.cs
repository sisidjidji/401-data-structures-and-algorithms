using System;
using Challenges;
using System.Text;
using Xunit;

namespace Challenges.Test
{
   public class multibracetests

    {

        [Theory]
        [InlineData("{}", true)]
        [InlineData("{", false)]
        [InlineData ("{{}}))",false)]
        [InlineData ("(())",true)]
        [InlineData("{{ttttt}}", true)]
        [InlineData("{{(bbb)})", false)]
        [InlineData("{kf{", false)]
        public void can_check_for_multi_braces(string brace,bool expected )
        {
            bool result = Multi_bracket_validation.MultiBracketValidation(brace);

            Assert.Equal(result,expected);
        }
    }
}
