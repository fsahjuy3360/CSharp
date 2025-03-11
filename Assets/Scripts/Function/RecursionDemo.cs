using UnityEngine;

// ���丮�� ���ϴ� �˰���(4!) 

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        // For Factorial
        Debug.Log(FactorialFor(4));

        // ����Լ� Factorial
        Debug.Log(Factorial(4));

        // ����Լ� Factor
        Debug.Log(Factor(4));
    }

    // For�� �̿� Factorial �� ���ϱ�
    int FactorialFor(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }

        return result;
    }

    // 3�� �����ڸ� �̿��� Factorial �����
    int Factor(int n)
    {
        return (n > 1) ? n * Factor(n - 1) : 1;
    }

    // ����Լ� �̿� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        // ���� ���� �κ�
        if(n == 1 || n == 0)
        {
            return 1;
        }

        // ��� ȣ�� �κ�
        return n * Factorial(n-1);
    }


}
/*
����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ��(��� ȣ��)�ϴ� �Լ�
- ����Լ� �Ű����� : �Ű������� ����,������ �ȴ�
- ����Լ� �ڵ� ��� �ȿ��� ����Լ��� ������ �� �ִ� ������ �ʿ��ϴ�


*/
