using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //"1, 2, 3, 4�� ���� �����߽��ϴ�"
        //1, 2, 3, 4�� ���� ���� �����ϸ� "��� �����߽��ϴ�" ���

        int answer = 1;
        /*
        switch(answer)
        {
            case 1:
                Debug.Log("1�� ���� �����Ͽ����ϴ�");
                break;

            case 2:
                Debug.Log("2�� ���� �����Ͽ����ϴ�");
                break;

            case 3:
                Debug.Log("3�� ���� �����Ͽ����ϴ�");
                break;

            case 4:
                Debug.Log("4�� ���� �����Ͽ����ϴ�");
                break;

            default:           
                Debug.Log("�߸� �����Ͽ����ϴ�");
                break;
        }*/

        if (answer == 1)
        {
            Debug.Log("1�� ���� �����Ͽ����ϴ�");
        }
        else if(answer == 2)
        {
            Debug.Log("2�� ���� �����Ͽ����ϴ�");
        }
        else if (answer == 3)
        {
            Debug.Log("3�� ���� �����Ͽ����ϴ�");
        }
        else if (answer == 4)
        {
            Debug.Log("4�� ���� �����Ͽ����ϴ�");
        }
        else
        {
            Debug.Log("�߸� �����Ͽ����ϴ�");
        }

    }
}
