using UnityEngine;

public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int sum = 0;
       for(int i = 0; i < 100+1; i = i + 3)
        {
            sum = sum + i;
        }

        int aa = 0;
       for(int j = 0; j < 100+1; j = j + 4)
        {
            aa = aa + j;
        }

        Debug.Log($"���� {sum + aa}");*/


        int n = 100;
        int sum = 0;

        for(int i = 1; i < n+1; i++)
        {
            if(i % 3 == 0 || i % 4 == 0)
            {
                sum = sum + i;
            }
        }

        Debug.Log($"���� {sum + i}");
    }

        
}

/*
[Q]
1���� 100������ ���� �߿��� 3�� ��� �Ǵ� 4�� ����� ���ؼ� ���ϴ� ���α׷� ����

[output]
���� {}






*/
