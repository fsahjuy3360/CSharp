using UnityEngine;

//로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Random 클래스 객체 생성
        System.Random random = new System.Random();

        // 배열 변수 선언 및 요소 수 생성
        int[] numbers = new int[6];

        int number = 0; // 랜덤값을 저장하는 변수
        bool flag = false; //중복 검사해서 중복이면 true, 아니면 false

        for (int i = 0; i < 6; i++)
        {
            // 1~45 랜덤값을 받아온다
            number = random.Next(1, 46);

            // 중복 체크 - number와 먼저 뽑힌 로또 번호와 비교하여 검사
            flag = false;
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }


            if (flag == false) //중복이 아니면
            {
                numbers[i] = number;
            }
            else  //중복이면 다시 계산하기 위해 인덱스를 조정한다
            {
                i--;
            }



        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}

/*
[Q]
로또 번호 생성기 만들기
[1] 6개 번호
[2] 1 ~ 45번 사이의 랜덤 번호
[3] 중복된 숫자가 나오면 안된다

[output] - 조건에 맞는 번호 6개 출력

*/
