using System;

namespace _2048
{
    class Move
    {
        public Move(int[,] arr, int k)
        {
            int i, j;

            //위
            if (k == 1)
            {
                for (i = 3; i > 0; i--)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[i, j] == 0)
                        {
                            continue;
                        }
                        if (arr[i, j] == arr[i - 1, j])
                        {
                            if (arr[0, j] == arr[i, j] && arr[1, j] == arr[i, j]
                                && arr[2, j] == arr[i, j] && arr[3, j] == arr[i, j])
                            {
                                arr[0, j] += arr[0, j];
                                arr[1, j] += arr[1, j];
                                arr[2, j] = 0;
                                arr[3, j] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 1:
                                        arr[i - 1, j] += arr[i, j];
                                        arr[i, j] = 0;
                                        break;
                                    case 2:
                                    case 3:
                                        if (arr[i, j] != arr[i - 2, j])
                                        {
                                            arr[i - 1, j] += arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        else
                                        {
                                            arr[i - 2, j] += arr[i - 1, j];
                                            arr[i - 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        break;

                                }
                            }
                        }
                        if (arr[i, j] != arr[i - 1, j])
                        {
                            if (arr[i - 1, j] != 0)
                            {
                                switch (i)
                                {
                                    case 1:
                                        continue;
                                    case 2:
                                    case 3:
                                        if (i == 3 && arr[i - 3, j] == 0)
                                        {
                                            arr[i - 3, j] = arr[i - 2, j];
                                            arr[i - 2, j] = arr[i - 1, j];
                                            arr[i - 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        if (arr[i - 2, j] == 0)
                                        {
                                            arr[i - 2, j] = arr[i - 1, j];
                                            arr[i - 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        if (arr[i - 2, j] == arr[i - 1, j])
                                        {
                                            arr[i - 2, j] += arr[i - 1, j];
                                            arr[i - 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        else
                                            continue;
                                        break;
                                }
                            }

                            else
                            {
                                arr[i - 1, j] = arr[i, j];
                                arr[i, j] = 0;
                            }
                        }
                    }
                }
            }

            //아래
            if (k == 2)
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[i, j] == 0)
                        {
                            continue;
                        }
                        if (arr[i, j] == arr[i + 1, j])
                        {
                            if (arr[0, j] == arr[i, j] && arr[1, j] == arr[i, j]
                                && arr[2, j] == arr[i, j] && arr[3, j] == arr[i, j])
                            {
                                arr[2, j] += arr[0, j];
                                arr[3, j] += arr[1, j];
                                arr[0, j] = 0;
                                arr[1, j] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 2:
                                        arr[i + 1, j] += arr[i, j];
                                        arr[i, j] = 0;
                                        break;
                                    case 1:
                                    case 0:
                                        if (arr[i, j] != arr[i + 2, j])
                                        {
                                            arr[i + 1, j] += arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        else
                                        {
                                            arr[i + 2, j] += arr[i + 1, j];
                                            arr[i + 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        break;
                                }
                            }
                        }
                        if (arr[i, j] != arr[i + 1, j])
                        {
                            if (arr[i + 1, j] != 0)
                            {
                                switch (i)
                                {
                                    case 2:
                                        continue;
                                    case 1:
                                    case 0:
                                        if (i == 0 && arr[i + 3, j] == 0)
                                        {
                                            arr[i + 3, j] = arr[i + 2, j];
                                            arr[i + 2, j] = arr[i + 1, j];
                                            arr[i + 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        if (arr[i + 2, j] == 0)
                                        {
                                            arr[i + 2, j] = arr[i + 1, j];
                                            arr[i + 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        if (arr[i + 2, j] == arr[i + 1, j])
                                        {
                                            arr[i + 2, j] += arr[i + 1, j];
                                            arr[i + 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        else
                                            continue;
                                        break;
                                }
                            }
                            else
                            {
                                arr[i + 1, j] = arr[i, j];
                                arr[i, j] = 0;
                            }
                        }
                    }
                }
            }

            //왼쪽
            if (k == 3)
            {
                for (i = 3; i > 0; i--)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[j, i] == 0)
                        {
                            continue;
                        }
                        if (arr[j, i] == arr[j, i - 1])
                        {
                            if (arr[j, 0] == arr[j, i] && arr[j, 1] == arr[j, i]
                                && arr[j, 2] == arr[j, i] && arr[j, 3] == arr[j, i])
                            {
                                arr[j, 0] += arr[j, 2];
                                arr[j, 1] += arr[j, 3];
                                arr[j, 2] = 0;
                                arr[j, 3] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 1:
                                        arr[j, i - 1] += arr[j, i];
                                        arr[j, i] = 0;
                                        break;
                                    case 2:
                                    case 3:
                                        if (arr[j, i] != arr[j, i - 2])
                                        {
                                            arr[j, i - 1] += arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        else
                                        {
                                            arr[j, i - 2] += arr[j, i - 1];
                                            arr[j, i - 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        break;

                                }
                            }
                        }
                        if (arr[j, i] != arr[j, i - 1])
                        {
                            if (arr[j, i - 1] != 0)
                            {
                                switch (i)
                                {
                                    case 1:
                                        continue;
                                    case 2:
                                    case 3:
                                        if (i == 3 && arr[j, i - 3] == 0)
                                        {
                                            arr[j, i - 3] = arr[j, i - 2];
                                            arr[j, i - 2] = arr[j, i - 1];
                                            arr[j, i - 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        if (arr[j, i - 2] == 0)
                                        {
                                            arr[j, i - 2] = arr[j, i - 1];
                                            arr[j, i - 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        if (arr[j, i - 2] == arr[j, i - 1])
                                        {
                                            arr[j, i - 2] += arr[j, i - 1];
                                            arr[j, i - 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        else
                                            continue;
                                        break;
                                }
                            }
                            else
                            {
                                arr[j, i - 1] = arr[j, i];
                                arr[j, i] = 0;
                            }
                        }
                    }
                }
            }

            //오른쪽
            if (k == 4)
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[j, i] == 0)
                        {
                            continue;
                        }
                        if (arr[j, i] == arr[j, i + 1])
                        {
                            if (arr[j, 0] == arr[j, i] && arr[j, 1] == arr[j, i]
                                && arr[j, 2] == arr[j, i] && arr[j, 3] == arr[j, i])
                            {
                                arr[j, 2] += arr[j, 0];
                                arr[j, 3] += arr[j, 1];
                                arr[j, 0] = 0;
                                arr[j, 1] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 2:
                                        arr[j, i + 1] += arr[j, i];
                                        arr[j, i] = 0;
                                        break;
                                    case 1:
                                    case 0:
                                        if (arr[j, i] != arr[j, i + 2])
                                        {
                                            arr[j, i + 1] += arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        else
                                        {
                                            arr[j, i + 2] += arr[j, i + 1];
                                            arr[j, i + 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        break;

                                }
                            }
                        }
                        if (arr[j, i] != arr[j, i + 1])
                        {
                            if (arr[j, i + 1] != 0)
                            {
                                switch (i)
                                {
                                    case 2:
                                        continue;
                                    case 1:
                                    case 0:
                                        if (i == 0 && arr[j, i + 3] == 0)
                                        {
                                            arr[j, i + 3] = arr[j, i + 2];
                                            arr[j, i + 2] = arr[j, i + 1];
                                            arr[j, i + 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        if (arr[j, i + 2] == 0)
                                        {
                                            arr[j, i + 2] = arr[j, i + 1];
                                            arr[j, i + 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        if (arr[j, i + 2] == arr[j, i + 1])
                                        {
                                            arr[j, i + 2] += arr[j, i + 1];
                                            arr[j, i + 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        else
                                            continue;
                                        break;
                                }
                            }
                            else
                            {
                                arr[j, i + 1] = arr[j, i];
                                arr[j, i] = 0;
                            }
                        }
                    }
                }
            }
        
        }
    }
}
