using UnityEngine;

// 명함 데이터를 관리하는 구조체
//[1] 구조체 정의, 선언
struct BusinessCard
{
    public string name;
    public int age;
    public string address;
}
public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 구조체 형식의 변수 선언
        BusinessCard mycard;

        //[3] 구조체에 속해 있는 데이터들의 초기화
        mycard.name = "홍길동";
        mycard.age = 20;
        mycard.address = "서울시 강동구";

        //[4] 구조체 사용
        Debug.Log($"이름: {mycard.name}, 나이: {mycard.age}, 주소: {mycard.address}");
    }
}
