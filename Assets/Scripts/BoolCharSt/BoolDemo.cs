using UnityEngine;
using UnityEngine.UIElements;

// bool (��) : ����, ���ڷ���, ��(true), ����(false) �� ����
public class BoolDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] bool ���� �����ϰ� �ʱ�ȭ
        bool bln = true;

        Debug.Log("bln: " + bln);

        bool isOut = false;

        Debug.Log("isOut: " + isOut);

    }
}
