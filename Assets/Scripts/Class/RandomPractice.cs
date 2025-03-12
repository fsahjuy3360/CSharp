using UnityEngine;

//�ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Random Ŭ���� ��ü ����
        System.Random random = new System.Random();

        // �迭 ���� ���� �� ��� �� ����
        int[] numbers = new int[6];

        int number = 0; // �������� �����ϴ� ����
        bool flag = false; //�ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        for (int i = 0; i < 6; i++)
        {
            // 1~45 �������� �޾ƿ´�
            number = random.Next(1, 46);

            // �ߺ� üũ - number�� ���� ���� �ζ� ��ȣ�� ���Ͽ� �˻�
            flag = false;
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }


            if (flag == false) //�ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            }
            else  //�ߺ��̸� �ٽ� ����ϱ� ���� �ε����� �����Ѵ�
            {
                i--;
            }



        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}

/*
[Q]
�ζ� ��ȣ ������ �����
[1] 6�� ��ȣ
[2] 1 ~ 45�� ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�

[output] - ���ǿ� �´� ��ȣ 6�� ���

*/
