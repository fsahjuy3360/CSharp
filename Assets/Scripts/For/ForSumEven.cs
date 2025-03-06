using System.Data.Common;
using UnityEngine;

//1부터 10까지의 정수 중 짝수의 합을 구하는 프로그램 구현
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 2 + 4 + 6 + 8 + 10
        int sum = 0;
        
        for(int i = 0; i < 11; i = i+2)
        {
            sum = sum + i;
        }

        Debug.Log($"합은: {sum}");
    }
}
