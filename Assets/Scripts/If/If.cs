using UnityEngine;

//���� score�� 60�� �̻��̸� "�հ�"�̶�� ���,
//score 61��
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int score = 61;

        if (score >= 60) //���ǹ��� ���̸� ��� �ȿ� �ִ� ���๮�� ����
        {
            //���๮
            Debug.Log("�հ�"); 
        }
    }
}
/*
if�� - ���ǹ�
���ǽ��� ���� ���� ���๮�� ����ȴ�
���ǽ��� �����̸� ���๮�� �������� �ʴ´�

//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�
if(���ǽ�)
{
    //���๮1
    //���๮2
    //���๮3
    //......
}

if(bool)
{
    //���๮1
    //���๮2
    //���๮3
    //......
}
*/