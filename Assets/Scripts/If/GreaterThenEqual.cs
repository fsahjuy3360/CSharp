using UnityEngine;

// 두 수를 입력 받아 그 중에서 큰 수를 출력
public class GreaterThenEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        //first와 second를 비교해서 큰 수를 출력

        if(first >= second)
        {
            Debug.Log($"큰 값은: {first}");
        }
        else
        {
            Debug.Log($"큰 값은: {second}");
        }
    }
}
