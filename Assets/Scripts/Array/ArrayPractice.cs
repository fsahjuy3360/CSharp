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

        // ���
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
3�� 3���� 2���� �迭�� �����
�迭�� ���� �ʱ�ȭ �ϴµ� ��� ���� �ε����� ������ 1, ��� ���� �ε����� �ٸ��� 0���� �����ϼ���
�����ϴ� ����� ���� for���� �̿��ϼ���

[output]
arr[0, 0] : 1
arr[0, 1] : 0
......
arr[2, 2] : 1

*/
