using UnityEngine;

public class IntToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 x를 선언하고 255롤 초기화
        int x = 255;

        //byte형 변수 y를 선언하고 x의 값으로 초기화

        // byte 0~255 저장범위

        byte y = (byte)x;

        Debug.Log(x + "->" + y);

    }
}
