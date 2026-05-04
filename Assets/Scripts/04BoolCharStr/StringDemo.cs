using UnityEngine;

public class StringDemo : MonoBehaviour
{
    void Start()
    {
        string name = "홍길동";
        const int AGE = 20;

        Debug.Log("name: " + name);//문자열 더하기 연산
        Debug.Log($"내 이름은 {name}");//문자열 보간법 ==> $" {변수명} "

        //안녕하세요 홍길동입니다
        Debug.Log($"안녕하세요 {name}입니다");
        //이름은 홍길동 나이는 20살입니다
        Debug.Log($"이름은 {name} 나이는 {AGE}살입니다");

    }
}
