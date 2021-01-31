using MVVMInterface.Interface;

namespace MVVMInterface.Model
{
    public class Subtracter : ICalculater
    {
        private int _storage = 0;

        /// <summary>
        /// 
        /// </summary>
        public int GetStorage => _storage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Calculate(int a, int b)
        {
            var result = a - b;
            _storage = result;
            return _storage;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            _storage = 0;
        }
    }
}
