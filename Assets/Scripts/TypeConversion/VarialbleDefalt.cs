using UnityEngine;

public class VarialbleDefalt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� �����ϰ� defalt(�⺻��) ������ �ʱ�ȭ
        int i = default;
        double d = default;
        char c = default;
        string s = default;

        //Debug.Log($"[{i}],[{d}],[{c}],[{s}]");
        Debug.Log($"[{i}],[{d}],[{c == System.Char.MinValue}],[{s == null}]");


    }
}
