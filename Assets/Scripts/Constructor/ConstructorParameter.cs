using UnityEngine;

namespace Constructor
{
    public class ConstructorParameter : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            My my = new My("홍길동", 21);
            my.PrintMyInfo();
        }
    }
}
