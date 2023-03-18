using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ReshapeTheMatrix
{
    public class Solution
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var originalX = mat.Length;

            if (originalX == 0)
            {
                return mat;
            
            }
            
            var originalY = mat[0].Length;

            if (originalY * originalX != r * c)
            {
                return mat;
            }

            var singleArr = mat.SelectMany(a => a);
            var result = new int[r][];

            var r1 = 0;
            var c1 = 0;

            foreach (var item in singleArr)
            {
                if (c1 == c)
                {
                    r1++;
                    c1 = 0;
                }

                if (c1 == 0) 
                {
                    result[r1] = new int[c];
                }

                result[r1][c1] = item;
                c1++;
            }

            return result;
        }
    }
}
