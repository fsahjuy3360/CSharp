using UnityEngine;

//안녕하세요를 3번 출력하는 프로그램
public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for (int i = 0; i < 3; i++)   반복횟수 3 - 0 = 3
        //for (int i = 1; i < 4; i++)   반복횟수 4 - 1 = 3
        //for (int i = 1; i <= 3; i++)  반복횟수 3 - 1 + 1 = 3

        //for (초기식; 조건식; 증감식)
        /*for (int i = 0; i < 3; i++)
        {
            //반복실행문
            Debug.Log("안녕하세요");
        }*/

        //[1] 초기식
        int i = 0;

        while (i < 3)    //[2] 조건식
        {
            // 반복 실행문
            Debug.Log("안녕하세요");

            // 증감식
            i++;
        }

        }
}

/*
while문 - 반복문
조건식이 true이면 반복문을 실행한다
조건식이 false면 while문을 종료한다

while(조건식)
{
    //반복 실행문
    
    //조건식에 들어가는 변수 증감식
}

조건식 판별(참) -> 반복문 실행 -> 조건식 판별(참) -> 반복문 실행 -> 조건식 판별(거짓)
-> while문 종료



*/
