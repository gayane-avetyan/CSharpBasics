using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        T[,] matrix;

        private int row;
        private int column;

        public Matrix(int row, int column)
        {
            this.row = row;
            this.column = column;
            matrix = new T[row, column];
        }

        public T this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.column);
            if (m1.row != m2.row || m1.column != m2.column)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.column; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] + m2[i, j];
                }
            }
            return m3;
        }


        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.column);
            if (m1.row != m1.column || m2.row != m2.column)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.column; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] - m2[i, j];
                }
            }
            return m3;
        }



        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.column);
            if (m1.row != m2.row || m1.column != m2.column)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.column; j++)
                {
                    m3[i, j] = (dynamic)m1[i, j] * m2[i, j];
                }
            }
            return m3;
        }



        public static Matrix<T> operator /(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> m3 = new Matrix<T>(m1.row, m1.column);
            if (m1.row != m2.row || m1.column != m2.column)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.column; j++)
                {
                    if ((dynamic)m2[i, j] == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    m3[i, j] = (dynamic)m1[i, j] + m2[i, j];
                }
            }
            return m3;
        }


        public static bool operator ==(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.row != m2.row || m1.column != m2.column)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m2.column; j++)
                {
                    if (!m1[i, j].Equals(m2[i, j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }



        public static bool operator !=(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.row != m2.row || m1.column != m2.column)
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.column; j++)
                {
                    if (!m1[i, j].Equals(m2[i, j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }



        public static bool operator true(Matrix<T> m)
        {
            for (int i = 0; i < m.row; i++)
            {
                for (int j = 0; j < m.column; j++)
                {
                    if (m[i, j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }



        public static bool operator false(Matrix<T> m)
        {
            for (int i = 0; i < m.row; i++)
            {
                for (int j = 0; j < m.column; j++)
                {
                    if (m[i, j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
