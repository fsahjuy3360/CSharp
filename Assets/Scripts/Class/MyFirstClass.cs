using Unity.VisualScripting;
using UnityEngine;

// ���� �޼��� ȣ��, �ν��Ͻ� �޼��� ȣ��
public class MyFirstClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����(static) �޼��� ȣ�� - StaticMethod() ȣ��
        //ȣ����: Ŭ�����̸�.�޼����̸�();
        ClassMember.StaticMethod();

        //[2] �ν��Ͻ�(Instance) �޼��� ȣ�� - InstanceMethod() ȣ��
        //ȣ����: 
        //Ŭ������ ��ü(��ü, Instance) ���� - Ŭ������ ���� ����
        //new Ű���带 �̿��Ͽ� ���ο� ��ü�� ����
        //(Ŭ���� �̸�) ��ü �̸� = new Ŭ���� �̸�();
        ClassMember member = new ClassMember();
        member.InstanceMethod();
    }
}
