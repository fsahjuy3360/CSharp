using System.Collections;
using UnityEngine;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Stack클래스의 객체(인스턴스, 개체) 생성
        Stack stack = new Stack();

        //[2] 데이터 넣기
        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        //[3] 데이터 꺼내오기
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        try
        {// 비어있는 스택에서 데이터 꺼내라
            Debug.Log(stack.Pop());
        }
        catch(System.Exception ex)
        {
            Debug.Log($"에러내용: {ex.Message}");
        }
    }
}

/*
Stack 클래스 : LIFO (Last In First Out) 형태로 데이터를 저장 관리하는 클래스
LIFO (Last In First Out) : 후입선출, 마지막에 넣은 데이터를 가장 먼저 꺼낸다
- 주방의 접시를 쌓아놓는 형태의 데이터 구조, 우물형 창고 데이터 구조

Push() : 스택 구종 데이터 입력
Pop() : 스택 구조에서 데이터 출력
Peek() : 스택 구조의 데이터 중 가장 마지막에 입력한 데이터의 값을 반환
count : 스택에 현재 저장되어 있는 데이터 수

Overflow : 스택이 가득 찼을 때 발생
Undeflow : 스택이 비었을 때 발생








*/
