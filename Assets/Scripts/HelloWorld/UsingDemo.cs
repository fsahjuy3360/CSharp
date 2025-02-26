// using 사용할 때 
/*
using UnityEngine;

public class UsingDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!!!");   
    }
}
*/

//using 사용하지 않으면

public class UsingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //네임 스페이스.클래스.메서드()
        UnityEngine.Debug.Log("Hello World!!!");
    }
}