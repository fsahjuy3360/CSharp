using UnityEngine;

//�ȳ��ϼ��並 3�� ����ϴ� ���α׷�
public class WhileDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for (int i = 0; i < 3; i++)   �ݺ�Ƚ�� 3 - 0 = 3
        //for (int i = 1; i < 4; i++)   �ݺ�Ƚ�� 4 - 1 = 3
        //for (int i = 1; i <= 3; i++)  �ݺ�Ƚ�� 3 - 1 + 1 = 3

        //for (�ʱ��; ���ǽ�; ������)
        /*for (int i = 0; i < 3; i++)
        {
            //�ݺ����๮
            Debug.Log("�ȳ��ϼ���");
        }*/

        //[1] �ʱ��
        int i = 0;

        while (i < 3)    //[2] ���ǽ�
        {
            // �ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            // ������
            i++;
        }

        }
}

/*
while�� - �ݺ���
���ǽ��� true�̸� �ݺ����� �����Ѵ�
���ǽ��� false�� while���� �����Ѵ�

while(���ǽ�)
{
    //�ݺ� ���๮
    
    //���ǽĿ� ���� ���� ������
}

���ǽ� �Ǻ�(��) -> �ݺ��� ���� -> ���ǽ� �Ǻ�(��) -> �ݺ��� ���� -> ���ǽ� �Ǻ�(����)
-> while�� ����



*/
