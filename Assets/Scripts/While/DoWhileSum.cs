using UnityEngine;

// dowhile���� �̿��ؼ� 1���� n������ ���� �߿��� Ȧ���� ���� ���ϴ� ���α׷� ����
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        // �ʱ��
        int i = 1;
        do
        {
            // �ݺ� ���๮
            if (i % 2 == 1)
            {
                sum += i;   
            }

            // ������
            i++;
        } while (i <= n);  // ���ǽ�

        Debug.Log($"1���� {n}���� Ȧ���� ��: {sum}");

    }
}
