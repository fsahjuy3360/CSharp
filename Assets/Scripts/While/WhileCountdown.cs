using UnityEngine;

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1���� 5���� 1�� ����
        // �ʱ��

        int i = 1;
        while (i <= 5)   // ���ǽ�
        {
            // �ݺ� ���๮
            Debug.Log($"ī��Ʈ�ٿ�: {i}");
            
            // ������
            i++;
        }

        Debug.Log("========================");

        // 5���� 1���� 1�� ����

        int j = 1;

        while (j < 6)
        {
            Debug.Log($"ī��Ʈ�ٿ�: {6-j}");
            j++;
        }
    }
}
