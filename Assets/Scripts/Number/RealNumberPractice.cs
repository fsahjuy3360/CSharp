using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float aa = 3.14f;
        double bb = 3.14;
        decimal cc = 3.14m;

        Debug.Log("float: " + aa);
        Debug.Log("double: " + bb);
        Debug.Log("decimal: " + cc);
    }
}



/*
[Q]
�Ǽ��� �� float 3.14, double 3.14 decimal 3.14 �� ����ϱ�

[output]
float: 3.14
double: 3.14
decimal: 3.14

*/