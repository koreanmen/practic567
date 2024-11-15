using System.Windows;

namespace Lib_11
{
    /// <summary>
    /// Класс для работы с парой чисел: инициализация случайными числами пары,
    /// попарное перемножение элементов пар, удвоение пар
    /// </summary>
    public class Pair
    {
        /// <summary>
        /// Генерация случайных чисел
        /// </summary>

        private Random rnd = new Random();
        /// <summary>
        /// Cвойство, которое представляет из себя массив чисел, использующийся для хранения пары чисел.
        /// </summary>
        private int[] _pairv;

        public int[] pairv
        {
            get { return _pairv; }
            set
            {
                if (value[0] % 2 == 0 && value[1] % 2 == 0)
                {
                    _pairv = value;
                }
            }
        }
        /// <summary>
        /// Конструктор, в котором происходит инициализация pairv
        /// </summary>

        public Pair(int firstVal, int secondVal)
        {
            pairv = new int[2] { firstVal, secondVal };
        }

        /// <summary>
        /// Конструктор, в котором инициализируется свойство pairv случайными значениями
        /// </summary>
        public Pair()
        {
            pairv = new int[2];
            for (int i = 0; i < pairv.Length; i++)
            {
                int random = 0;
                do
                {
                    random = rnd.Next(-10, 11);
                }
                while (random % 2 != 0);
                pairv[i] = random;

            }
        }

        /// <summary>
        /// Метод, который попарно перемножает элементы пар
        /// </summary>
        //public int[] PairPair(Pair pair)
        //{
        //    int[] multPairs = new int[2];
        //    for (int i = 0; i < pairv.Length; i++)
        //    {
        //        multPairs[i] = pairv[i] * pair.pairv[i];
        //    }
        //    return multPairs;
        //}
        ///// <summary>
        ///// Метод, который удваивает элементы пары
        ///// </summary>
        ///// 
        //public void Mult()
        //{

        //    for (int i = 0; i < pairv.Length; i++)
        //    {
        //        pairv[i] *= 2;
        //    }
        //}
        ///// <summary>
        ///// Метод, который увеличивает элементы пары на множитель
        ///// </summary>
        //public void Mult(int mult)
        //{
        //    for (int i = 0; i < pairv.Length; i++)
        //    {
        //        pairv[i] *= mult;
        //    }
        //} 
        
        /// <summary>
        /// Перегрузка оператора инкремента, для удвоения пары
        /// </summary>
        public static Pair operator ++(Pair pair)
        {
            pair.pairv = new int[] { pair.pairv[0] * 2, pair.pairv[1] * 2 };
            return pair;
        }
        /// <summary>
        /// Перегрузка унарного оператора инкремента для перемножения пар чисел
        /// </summary>
        public static Pair operator *(Pair pair1, Pair pair2)
        {
            return new Pair
            {
                pairv = new int[]
                {
                    pair1.pairv[0]*pair2.pairv[0],
                    pair1.pairv[1]*pair2.pairv[1]
                }
            };
        }
    }
    /// <summary>
    /// класса RightAngled
    /// </summary>
    public class RightAngled : Pair
    {
        /// <summary>
        /// Конструктор класса RightAngled
        /// </summary>
        public RightAngled(int fkat, int skat) : base(fkat, skat) { }

        /// <summary>
        /// Метод для вычисления гипотенузы
        /// <summary>
        /// <returns>Гипотенуза</returns>
        public double CalcHyp()
        {
            return Math.Sqrt(Math.Pow(pairv[0], 2) + Math.Pow(pairv[1], 2));
        }

        /// <summary>
        /// Метод для вычисления площади треугольника
        /// </summary>
        /// <returns>Площадь</returns>
        public double CalcArea()
        {
            return 0.5 * Math.Abs(pairv[0]) * Math.Abs(pairv[1]);
        }
    }

}
