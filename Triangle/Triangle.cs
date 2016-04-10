using System;

namespace Triangle
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Вычислить площадь по трем сторонам
        /// </summary>
        /// <param name="a">сторона</param>
        /// <param name="b">сторона</param>
        /// <param name="c">сторона</param>
        /// <returns>площадь</returns>
        public static double GetSquare(double a, double b, double c)
        {

            if (a <= 0 || b <= 0 || c <= 0)//некорректные данные
                throw new ArgumentException($"All parameters must be greater than zero. Input: a {a}; b {b}, c {c}");
            if (a == double.MaxValue || b == double.MaxValue || c == double.MaxValue)
                return double.PositiveInfinity;//сторона - максимальной значение типа double
            var p = a / 2 + b / 2 + c / 2;//периметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
