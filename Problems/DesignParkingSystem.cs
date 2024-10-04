namespace LeetCode_Practice
{
    public class ParkingSystem {
    
        private int _bigSpaces;
        private int _mediumSpaces;
        private int _smallSpaces;
    
        public ParkingSystem(int big, int medium, int small) {
            _bigSpaces = big;
            _mediumSpaces = medium;
            _smallSpaces = small;    
        }
        
        public bool AddCar(int carType) {
            switch (carType)
            {
                case 1:
                    if (_bigSpaces > 0) 
                    {
                         _bigSpaces--; 
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case 2:
                    if (_mediumSpaces > 0) 
                    {
                         _mediumSpaces--; 
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                case 3:
                    if (_smallSpaces > 0) 
                    {
                         _smallSpaces--; 
                         return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
            return false;
        }
    }
    public class DesignParkingSystem
    {
        [Fact]
        public void DesignParkingSystem_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}