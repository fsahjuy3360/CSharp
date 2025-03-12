using UnityEditor.Build.Player;
using UnityEngine;

// 중첩 구조체: 구조체 안에 구조체
// 성적을 관리하는 구조체 만들기
// 과목의 점수를 관리하는 구조체 선언
struct Score
{
    public int kor;
    public int eng;
    
}
// 학생 정보를 관리하는 구조체 선언 - 성적 포함
struct Studant
{
    public int number;
    public string name;
    public Score scores;
}
public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 구조체 배열 변수 선언 및 요소 수 생성
        Studant[] studants = new Studant[3];
        //[2] 학생 구조체 초기화
        studants[0].number = 1;
        studants[0].name = "홍길동";
        studants[0].scores.kor = 100;
        studants[0].scores.eng = 90;

        studants[1].number = 2;
        studants[1].name = "백두산";
        studants[1].scores.kor = 90;
        studants[1].scores.eng = 80;

        studants[2].number = 3;
        studants[2].name = "임꺽정";
        studants[2].scores.kor = 90;
        studants[2].scores.eng = 75;

        //[3] 학생 구조체 사용 - 성적표 출력
        for (int i = 0; i < studants.Length; i++)
        {
            Debug.Log($"{studants[i].number} - {studants[i].name}: 국어 {studants[i].scores.kor} 점, 영어 {studants[i].scores.eng} 점 ");
        }
    }


}
