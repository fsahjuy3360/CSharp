using UnityEngine;

// 두 수의 합을 구하는 함수 만들기
public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 두 정수(3, 4)의 합을 반환값으로 받아 출력하기
        int result = GetSum(3, 4);
        Debug.Log(result);
    }

//[1] 두 수의 합을 구하는 함수 만들기 - 매개변수와 반환값 이용
// 매개변수로 들어온 두 정수의 합을 반환하는 함수 선언
int GetSum(int x, int y)
    {
        //int sum = x + y;
        //return sum;

        return (x + y);
    }
}
