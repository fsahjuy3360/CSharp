using UnityEditor.Build.Player;
using UnityEngine;

// ��ø ����ü: ����ü �ȿ� ����ü
// ������ �����ϴ� ����ü �����
// ������ ������ �����ϴ� ����ü ����
struct Score
{
    public int kor;
    public int eng;
    
}
// �л� ������ �����ϴ� ����ü ���� - ���� ����
struct Studant
{
    public int number;
    public string name;
    public Score scores;
}
public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü �迭 ���� ���� �� ��� �� ����
        Studant[] studants = new Studant[3];
        //[2] �л� ����ü �ʱ�ȭ
        studants[0].number = 1;
        studants[0].name = "ȫ�浿";
        studants[0].scores.kor = 100;
        studants[0].scores.eng = 90;

        studants[1].number = 2;
        studants[1].name = "��λ�";
        studants[1].scores.kor = 90;
        studants[1].scores.eng = 80;

        studants[2].number = 3;
        studants[2].name = "�Ӳ���";
        studants[2].scores.kor = 90;
        studants[2].scores.eng = 75;

        //[3] �л� ����ü ��� - ����ǥ ���
        for (int i = 0; i < studants.Length; i++)
        {
            Debug.Log($"{studants[i].number} - {studants[i].name}: ���� {studants[i].scores.kor} ��, ���� {studants[i].scores.eng} �� ");
        }
    }


}
