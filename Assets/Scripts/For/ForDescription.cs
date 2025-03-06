using UnityEngine;

public class ForDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //안녕하세요를 3번 출력하는 프로그램
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("안녕하세요");
        }

        // 초기식 i: 0 -> 판별식(참) -> 출력 -> 증감식 i: 1 -> 판별식(참) -> 출력
        // -> 증감식 i: 2 -> 판별식(참) -> 출력 -> 증감식 i: 3 -> 판별식(거짓)
        // -> for문 종료
    }
}

/*
for : 반복문
초기식 : 조건식에서 사용하는 변수의 초기값을 설정(초기화)
조건식 : 조건식을 참, 거짓으로 판별, 참이면 반복 실행문을 실행하고 거짓이면 for문을 종료
증감식 : 반복물을 실행할 때 마다 실행한 직후 조건식에서 사용하는 변수의 값을 다시 연산해주는 식

for(초기식; 조건식; 증감식)
{
    //반복 실행문
}

초기식 -> 조건식 판별(참) -> 반복 실행문 실행 -> 증감식 -> 조건식 판별(참) -> 








*/
