using UnityEngine;

//[1] ����ü ����, ���� : �� ���� ������ �����ϴ� ����ü �����
struct Point
{
    public int x;  // public Ű���带 �����Ͽ� �ܺο��� int x������ ���� �����ϵ��� ����
    public int y;
}

public class StructDescreption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ����ü ������ ���� ���� : Point ����ü ������ ����
        Point p;

        //[3]Point ����ü�� x, y ������ ���� ����(����, �Ҵ�) �ʱ�ȭ
        p.x = 100;
        p.y = 200;

        //[4] ���
        Debug.Log($"x: {p.x}, y: {p.y}");
    }
}

/*
Varialble(����) : �����͸� �����ϴ� �׸�
Array(�迭) : �ϳ��� �̸����� ���� ������ �����͸� ���� �� ��� �׸�, ����
Struct(����ü) : �ϳ��� �̸����� ���� �ٸ� ������ �����͵�, �Ǵ� �Լ����� ��� �����ϴ� �׸� (������ ����)
               : ����� ���� ������ ����

// ����ü ����
struct (����ü �̸�)
{
    // ���� �ٸ� ������ �����͵�
    // �Լ���
}


*/
