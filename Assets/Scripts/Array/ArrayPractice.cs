using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[,] intArray = new int[3, 3];

        for (int i =0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                {
                    intArray[i, j] = 1;
                }
                else
                {
                    intArray[i, j] = 0;
                }
                    
            }
        }

        // 출력
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"intArray[{i}, {j}]: {intArray[i, j]}");
            }
        }
    } 
}

/*
[Q]
3행 3열의 2차원 배열을 만들고
배열의 값을 초기화 하는데 행과 열의 인덱스가 같으면 1, 행과 열의 인덱스가 다르면 0으로 저장하세요
저장하는 방법을 이중 for문을 이용하세요

[output]
arr[0, 0] : 1
arr[0, 1] : 0
......
arr[2, 2] : 1

*/
