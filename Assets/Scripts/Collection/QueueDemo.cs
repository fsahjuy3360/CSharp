using System.Collections;
using UnityEngine;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Queue Ŭ������ �ν��Ͻ�(��ü, ��ü) ����
        Queue queue = new Queue();

        //[2] ť�� ������ �ֱ� Enqueue
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3] ť���� ������ ������ DEqueue - �ⱸ���� �� �տ� �ִ� �����͸� ������
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
       

    }
}

/*
Queue Ŭ���� : FIFO(First In First Out) ���·� �����͸� ����, �����ϴ� Ŭ����
FIFO(First In First Out) : ���Լ���, ���� ���� ���� �����͸� ���� ���� ������
�ͳ��� â�� ������ ����, ���ǥ

Enqueue() : ť�� ������ �ֱ�
Dequeue() : ť�� ������ ������








*/
