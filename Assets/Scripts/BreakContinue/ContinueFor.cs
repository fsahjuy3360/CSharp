using UnityEngine;

// continue문은 반복문에서 continue문을 만나면 continue문 아래에 있는 실행문을 실행하지 않고
// 다음 반복문의 조건식을 판별한 다음 반복문을 실행한다
public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 5까지 홀수만 출력하는 프로그램
        /*for (int i = 1; i <= 5; i ++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
            
        }*/

        for (int i = 1; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                continue;  // 현재 반복 실행 중인 반복문을 중지하고 다음 반복문으로 이동하라
            }

            Debug.Log(i);
         

        } //<- 여기로

    }
}
