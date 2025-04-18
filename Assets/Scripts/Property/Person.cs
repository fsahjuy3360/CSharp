using UnityEngine;

namespace Property
{
    public class Person
    {
        // 필드, 멤버변수
        private string name;

        // public한 Proprety(속성)를 이용해 private한 필드에 접근
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }


        // public한 메서드를 이용해 private한 필드에 접근
        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
