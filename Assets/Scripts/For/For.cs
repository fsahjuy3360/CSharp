using UnityEngine;

//1���� 5���� 1�� �����ϴ� ���� ����ϴ� ���α׷�
//Count: 1
//Count: 2
//Count: 3
//Count: 4
//Count: 5
public class For : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Count: {i + 1}");
        }

        /*for (int i = 1; i <= 5; i++)
        {
            Debug.Log($"Count: {i}");
        }*/

        /*for (int i = 1; i < 6; i++)
        {
            Debug.Log($"Count: {i}");
        }*/
    }
}
