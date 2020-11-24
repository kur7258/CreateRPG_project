using System;
using System.Collections.Generic;
using System.Text;

namespace Kim2048_Ver_Class
{
    class ReadKey : MakeArray
    {
        public ReadKey() { }

        public void LeftKey()
        {
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < array.Length; i++) // 세로행 반복
                {
                    for (int j = 3; j > 0; j--) // 가로행 반복
                    {  // 바로 앞 행이 0인지 확인 또는 앞열과 뒷열이 같은지 확인
                        if (array[i][j - 1] == 0 || array[i][j - 1] == array[i][j])
                        {
                            int temp1 = array[i][j - 1];
                            int temp2 = array[i][j];
                            int sum = temp1 + temp2;
                            array[i][j] = 0;
                            array[i][j - 1] = sum;
                        }
                        else if (array[i][j - 1] != array[i][j])
                        {
                            for (int a = 0; a < array.Length; a++)
                            {
                                for (int b = 0; b < array.Length - 1; b++)
                                {
                                    int temp = array[a][b + 1];
                                    if (array[a][b] == 0)
                                    {
                                        array[a][b] = temp;
                                        array[a][b + 1] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void RightKey()
        {
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    { // 앞행이 0인지 또는 앞행과 뒷행이 같은지 확인
                        if (array[i][j + 1] == 0 || array[i][j + 1] == array[i][j])
                        {
                            int temp1 = array[i][j + 1];
                            int temp2 = array[i][j];
                            int sum = temp1 + temp2;
                            array[i][j] = 0;
                            array[i][j + 1] = sum;
                        }
                        else if (array[i][j + 1] != array[i][j])
                        {
                            for (int a = 0; a < array.Length; a++)
                            {
                                for (int b = 3; b > 0; b--)
                                {
                                    int temp = array[a][b - 1];
                                    if (array[a][b] == 0)
                                    {
                                        array[a][b] = temp;
                                        array[a][b - 1] = 0;
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
        public void UpKey()
        {
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 3; j > 0; j--)
                    {   // 앞행이 0인지 또는 앞행과 뒷행이 같은지 확인
                        if (array[j - 1][i] == 0 || array[j - 1][i] == array[j][i])
                        {
                            int temp1 = array[j - 1][i];
                            int temp2 = array[j][i];
                            int sum = temp1 + temp2;
                            array[j][i] = 0;
                            array[j - 1][i] = sum;
                        }
                        else if (array[j - 1][i] != array[j][i])
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                for (int a = 0; a < array.Length - 1; a++)
                                {
                                    int temp = array[a + 1][b];
                                    if (array[a][b] == 0)
                                    {
                                        array[a][b] = temp;
                                        array[a + 1][b] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void DownKey()
        {
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {   // 앞행이 0인지 또는 앞행과 뒷행이 같은지 확인
                        if (array[j + 1][i] == 0 || array[j + 1][i] == array[j][i])
                        {
                            int temp1 = array[j][i];
                            int temp2 = array[j + 1][i];
                            int sum = temp1 + temp2;
                            array[j][i] = 0;
                            array[j + 1][i] = sum;
                        }
                        else if (array[j + 1][i] != array[j][i])
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                for (int a = 3; a > 0; a--)
                                {
                                    int temp = array[a - 1][b];
                                    if (array[a][b] == 0)
                                    {
                                        array[a][b] = temp;
                                        array[a - 1][b] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
