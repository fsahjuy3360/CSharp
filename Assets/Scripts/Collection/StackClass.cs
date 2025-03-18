using System.Collections;
using UnityEngine;

// Collections : Stack, Queue, ArrayList, HashTable
public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Stack 클래스의 인스턴스(객체) 생성
        Stack st = new Stack();

        // Stack에 데이터 넣기: Push
        st.Push("first");
        st.Push("Second");

        // Stack에서 데이터 꺼내기: Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());




    }
}
