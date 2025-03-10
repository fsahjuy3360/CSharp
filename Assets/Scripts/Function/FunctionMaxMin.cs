using UnityEngine;


public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = One(3, 5);
        Debug.Log($"3과 5중 큰 수는: {result}");

        int result2 = Abc(-3, -5);
        Debug.Log($"-3과 -5중 작은 수는: {result2}");
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

        //int maxValue = (조건식) ? x : y; - 3항 연산자
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
1. 매개변수로 입력받은 두 개의 정수 중 큰 수를 반환하는 함수
2. 매개변수로 입력받은 두 개의 정수 중 작은 수를 반환하는 함수
3. 3, 5를 입력받아 큰 수 출력하기
4. -3, -5를 입력받아 작은 수 출력하기

[output]
3과 5중 큰 수는 (반환값) 이다
-3과 -5중 작은 수는 (반환값) 이다







*/
