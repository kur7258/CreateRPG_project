#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MAX_SIZE 100
int A[10000], B[10000];//정렬 전, 정렬 후

int main(void)
{
	int n = MAX_SIZE, i, k = 10000;//배열 갯수, 반복문에 넣을 것, 숫자범위 0~9999

	printf("정렬전: ");
	srand(time(NULL));
	for (i = 0; i < n; i++)
	{
		A[i] = rand() % k;
		printf("%d ", A[i]);
	}

	RadixSort(A, n, B, k);

	printf("\n정렬후: ");
	for (i = 0; i < n; i++)
	{
		printf("%d ", B[i]);
	}
}

int RadixSort(int A[], int n, int B[], int k)
{
	int i, j, N[10000], a;//N은 누적합, a는 자릿수, 나머지는 반복문
	for (a = 10; a <= k; a *= 10) //자릿수 나누기
	{
		for (i = 0; i < k; i++)//초기화
		{
			N[i] = 0;
		}
		for (j = 0; j < n; j++)
		{
			N[A[j]%a]++; //a자리의 숫자 갯수세기
		}
		for (i = 1; i < k; i++)
		{
			N[i] = N[i] + N[i - 1];//a자리의 숫자 누적합
		}
		for (j = 0; j < n; j++)
		{
			B[--N[A[j]]] = A[j];//자릿수 순서대로 배열
		}
	}
}
