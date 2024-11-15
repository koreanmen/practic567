using System.Windows;

namespace Lib_11
{
    /// <summary>
    /// ����� ��� ������ � ����� �����: ������������� ���������� ������� ����,
    /// �������� ������������ ��������� ���, �������� ���
    /// </summary>
    public class Pair
    {
        /// <summary>
        /// ��������� ��������� �����
        /// </summary>

        private Random rnd = new Random();
        /// <summary>
        /// C�������, ������� ������������ �� ���� ������ �����, �������������� ��� �������� ���� �����.
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
        /// �����������, � ������� ���������� ������������� pairv
        /// </summary>

        public Pair(int firstVal, int secondVal)
        {
            pairv = new int[2] { firstVal, secondVal };
        }

        /// <summary>
        /// �����������, � ������� ���������������� �������� pairv ���������� ����������
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
        /// �����, ������� ������� ����������� �������� ���
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
        ///// �����, ������� ��������� �������� ����
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
        ///// �����, ������� ����������� �������� ���� �� ���������
        ///// </summary>
        //public void Mult(int mult)
        //{
        //    for (int i = 0; i < pairv.Length; i++)
        //    {
        //        pairv[i] *= mult;
        //    }
        //} 
        
        /// <summary>
        /// ���������� ��������� ����������, ��� �������� ����
        /// </summary>
        public static Pair operator ++(Pair pair)
        {
            pair.pairv = new int[] { pair.pairv[0] * 2, pair.pairv[1] * 2 };
            return pair;
        }
        /// <summary>
        /// ���������� �������� ��������� ���������� ��� ������������ ��� �����
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
    /// ������ RightAngled
    /// </summary>
    public class RightAngled : Pair
    {
        /// <summary>
        /// ����������� ������ RightAngled
        /// </summary>
        public RightAngled(int fkat, int skat) : base(fkat, skat) { }

        /// <summary>
        /// ����� ��� ���������� ����������
        /// <summary>
        /// <returns>����������</returns>
        public double CalcHyp()
        {
            return Math.Sqrt(Math.Pow(pairv[0], 2) + Math.Pow(pairv[1], 2));
        }

        /// <summary>
        /// ����� ��� ���������� ������� ������������
        /// </summary>
        /// <returns>�������</returns>
        public double CalcArea()
        {
            return 0.5 * Math.Abs(pairv[0]) * Math.Abs(pairv[1]);
        }
    }

}
