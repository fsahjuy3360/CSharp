using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����
        int x = 2;

        switch(x)
        {
            case 1:
                Debug.Log("x�� 1 �Դϴ� ");
                break;

            case 2:
                Debug.Log("x�� 2 �Դϴ�");
                break;
        }

        Debug.Log("���α׷� ����");
    }
}

/*
switch�� : ���ǹ� - ���ù�

switch(����) : Data �� �Ǻ�
{
    case 1��:
        //���๮1
        break;
    
    case 2��:
        //���๮2
        break;
     
    case 3��:
        //���๮3
        break;
    
    defalt: //��� case�� �ƴϸ�
        //���๮ 4
        break;
}


if(���ǽ�) : ���ǽ��� ��, ���� �Ǻ�
{
    ���๮ 1
}
else
{
    ���๮ 2
}



*/
