using UnityEngine;
using UnityEngine.Rendering;

// ForEach : �迭�� ����� ������ ������� ��� �����ͼ� ���
public class ArrayForEach : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �迭 ��ҵ��� ���� ��� �����ͼ� ������ ���ϴ� ���α׷�

        float[] arr = { 10.5f, 20.1f, 30.3f };
        float sum = 0f;

       /* for(int i = 0; i < 3; i++)
        {
            sum = sum + arr[i];
        }*/

        foreach(float f in arr)
        {
            //�ݺ� ���๮
            sum = sum + f;
        }
        Debug.Log($"������ {sum}");
    }
}
/*

ForEach : �迭�� ����� ������ ������� ��� �����ͼ� ���
�迭�� �����͸� ó������ ������ �������� �� �̻� ������ �����Ͱ� ������ �ݺ��� ����

foreach(�迭�� ������ Ÿ��(float) ���� �̸�(f) in �迭���� �̸�(arr))
{
    // �ݺ� ���๮
}

 */
