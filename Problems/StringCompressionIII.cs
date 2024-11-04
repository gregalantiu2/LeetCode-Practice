namespace LeetCode_Practice
{
    public partial class Solution {
        public string CompressedString(string word) {
            List<Tuple<char, int>> list = new List<Tuple<char, int>>();
            string comp = "";
    
            for (int i = 0; i < word.Length; i++)
            {
                if (list.Count > 0 && list[list.Count - 1].Item1 == word[i])
                {
                    if (list[list.Count - 1].Item2 == 9)
                    {
                        comp += list[list.Count - 1].Item2.ToString() + list[list.Count - 1].Item1;
                        list.Add(new Tuple<char, int>(word[i], 1));
                    }
                    else{
                        list[list.Count - 1] = new Tuple<char, int>(word[i], list[list.Count - 1].Item2 + 1);
                    }
                }
                else{
                    if (list.Count > 0)
                    {
                        comp += list[list.Count - 1].Item2.ToString() + list[list.Count - 1].Item1;
                    }
                    list.Add(new Tuple<char, int>(word[i], 1));
                }
            }
    
            comp += list[list.Count - 1].Item2.ToString() + list[list.Count - 1].Item1;
    
            return comp;
        }
    }
    public class StringCompressionIII
    {
        [Fact]
        public void StringCompressionIII_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}