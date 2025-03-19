using UnityEngine;

namespace Constructor
{
    public class DestrucrorTest
    {
        // 생성자
        public DestrucrorTest()
        {
            Debug.Log("[1] 생성");
        }

        // 메서드
        public void Run()
        {
            Debug.Log("[2] 실행");
        }

        // 소멸자
        ~DestrucrorTest()
        {
            Debug.Log("[3] 소멸");
        }
    }
}
