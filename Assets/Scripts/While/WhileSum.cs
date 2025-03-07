using UnityEngine;

// while문을 이용해서 1부터 n까지의 합을 구하는 프로그램 구현
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        // [1] 초기식
        int i = 1;

        while (i < n+1) // [2]조건식
        {
            // 반복 실행문 - 누적
            sum += i;
            
            // [3]증감식    
            i++;
        }

        Debug.Log($"1부터 {n}까지의 합: {sum}");
    }
}
