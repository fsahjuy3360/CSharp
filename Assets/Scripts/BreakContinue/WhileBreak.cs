using UnityEngine;

// 1부터 10까지의 정수의 합을 구하는 프로그램 구현
// 구한 합(sum)이 22(goal)이상이 되면 더 이상 합을 구하지 않는다 
// While문 이용
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        int i = 1;
        while (i < n+1)
        {
            sum += i;
            if (sum >= goal)
            {
                break;
            }
            i++;
        }
        Debug.Log(sum);

    }
}
