namespace LeetCode_Practice
{
    public class UnitTest2
    {
        public int Test(int x)
        {
            return 1;
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1, Test(1));
        }
    }
}