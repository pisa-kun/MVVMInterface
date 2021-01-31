namespace MVVMInterface.Interface
{
    interface ICalculater
    {
        /// <summary>
        /// 直前に計算した値を取得
        /// </summary>
        int GetStorage { get; }

        /// <summary>
        /// 計算する
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Calculate(int a, int b);

        /// <summary>
        /// clear
        /// </summary>
        void Clear();
    }
}
