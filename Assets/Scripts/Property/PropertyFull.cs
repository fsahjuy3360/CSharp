using UnityEngine;

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] Person 클래스의 인스턴스 생성
            Person person = new Person();

            //[2] 메서드를 이용하여 name 값 저장 및 사용
            person.SetName("홍길동");

            Debug.Log(person.GetName());

            //[3] public한 Proprety(속성)를 이용해 name 값 저장 및 사용
            //Name 속성의 set
            person.Name = "백두산";
            //Name 속성의 get
            Debug.Log(person.Name);




        }
    }
}

