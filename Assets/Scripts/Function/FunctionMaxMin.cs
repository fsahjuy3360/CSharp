using UnityEngine;


public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = One(3, 5);
        Debug.Log($"3�� 5�� ū ����: {result}");

        int result2 = Abc(-3, -5);
        Debug.Log($"-3�� -5�� ���� ����: {result2}");
    }

    int One(int x, int y)
    {
        if (x >= y)
        {
            return x;
        }
        else
        {
            return y;
        }

        //int maxValue = (���ǽ�) ? x : y; - 3�� ������
        //return maxValue;

        //return (x > y) ? x : y;



    }

    int Abc(int x, int y)
    {
        if (x <= y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

/*
[Q]
1. �Ű������� �Է¹��� �� ���� ���� �� ū ���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է¹��� �� ���� ���� �� ���� ���� ��ȯ�ϴ� �Լ�
3. 3, 5�� �Է¹޾� ū �� ����ϱ�
4. -3, -5�� �Է¹޾� ���� �� ����ϱ�

[output]
3�� 5�� ū ���� (��ȯ��) �̴�
-3�� -5�� ���� ���� (��ȯ��) �̴�







*/
