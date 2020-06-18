using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Test
{
    public class JoinTableTest
    {

        [Fact]
        public void test_join_table()
        {
            Dictionary<string, string> hash1 = new Dictionary<string, string>();
            Dictionary<string, string> hash2 = new Dictionary<string, string>();

            hash1.Add("hi", "hello");
            hash1.Add("green", "blue");
            hash1.Add("pink,", "purple");

            hash2.Add("hi", null);

            List<string[]> result = LeftJoinTable.Leftjoin(hash1, hash2);

            string[] expected1 = new string[] { "hi", "hello", null };
            string[] expected2 = new string[] { "green", "blue",null };
            string[] expected3 = new string[] { "pink,", "purple",null };

            Assert.Contains(expected1, result);
            Assert.Contains(expected2, result);
            Assert.Contains(expected3, result);

        }
    }
}
