using UnityEngine;
using UnityEngine.Rendering;

// ForEach : 배열에 저장된 값들을 순서대로 모두 가져와서 사용
public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 배열 요소들의 값을 모두 가져와서 총합을 구하는 프로그램

        float[] arr = { 10.5f, 20.1f, 30.3f };
        float sum = 0f;

       /* for(int i = 0; i < 3; i++)
        {
            sum = sum + arr[i];
        }*/

        foreach(float f in arr)
        {
            //반복 실행문
            sum = sum + f;
        }
        Debug.Log($"총합은 {sum}");
    }
}
/*

ForEach : 배열에 저장된 값들을 순서대로 모두 가져와서 사용
배열의 데이터를 처음부터 끝까지 가져오고 더 이상 가져올 데이터가 없으면 반복문 종료

foreach(배열의 데이터 타입(float) 변수 이름(f) in 배열변수 이름(arr))
{
    // 반복 실행문
}

 */
