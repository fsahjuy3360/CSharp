
using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;

        result = Add(5, 3);
        Debug.Log(result);

        result = Subtract(5, 3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Devide(5, 3);
        Debug.Log(result);

        result = Remainder(5, 3);
        Debug.Log(result);

        Hi("�ȳ��ϼ���");
    }

    int Add(int x, int y)
    {
        return x + y;
    }

    int Subtract(int x, int y) => x - y;   // ȭ��ǥ �Լ�, ���ٽ�, ����� �Լ�

    int Multiply(int x, int y) => x * y;


    int Devide(int x, int y) => x / y;


    int Remainder(int x, int y) => x % y;

    void Hi(string msg) => Debug.Log(msg);
}

/*[Q]
 ��Ģ������ ���ϴ� �Լ� �����
 �� ���� ������ �Է¹޾� +, -, *, /, % ����Ͽ�
 ������� ����� �Լ� �����
 
add, subtract, multiply, devide, remainder
 �Է°� 5, 3
 
 [output]
 


*/
