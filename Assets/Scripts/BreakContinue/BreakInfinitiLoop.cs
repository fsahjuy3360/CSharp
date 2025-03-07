using UnityEngine;

// break;로 무한루프를 빠져 나오기
public class BreakInfinitiLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한루프 - 무한 반복

        /*for (; ; )
        {

        }*/

        /*while (true)
        {

        }*/

        int number = 0;

        // number가 5 이상이면 while문 종료
        while (true)
        {
            //반복 실행문

            Debug.Log(number);

            number++;
            if (number >= 5)
            {
                break;
            }
        }
    }
}
