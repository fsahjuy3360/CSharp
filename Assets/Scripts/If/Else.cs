using UnityEngine;

//���� score�� 60�� �̻��̸� "�հ�"�̶�� ����ϰ�
//�ƴϸ� "���հ�" �̶�� ���
//score 61��
public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 59;   //[1]

        //���� score�� 60�� �̻��̸�
        if (score >= 60)   
        {
            Debug.Log("�հ�");  //[2]
        }
        else //���ǽ��� �ƴϸ�
        {
            Debug.Log("���հ�");  //[3]
        }

        Debug.Log("����");   //[4]

        // score = 59; [1] -> [3] -> [4]
        // score = 61; [1] -> [2] -> [4]
    }
}
