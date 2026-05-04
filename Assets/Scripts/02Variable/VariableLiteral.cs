using UnityEngine;

//데이터 값(Literal) - 변수에 저장할 데이터 값의 종류
public class VariableLiteral : MonoBehaviour
{
    void Start()
    {
        //[1] 변수 선언
        int num; //정수
        double su; //실수
        bool flag; //참(true), 거짓(false)
        string str; //문자열
        char c; //문자

        //[2] 변수에 값 저장
        num = 1234;
        su = 3.1415;
        flag = false; //true, false
        str = "안녕하세요";
        c = 'b';

        //[3] 변수 사용하기
        Debug.Log("num: " + num);
        Debug.Log("su: " + su);
        Debug.Log("flag: " + flag);
        Debug.Log("str: " + str);
        Debug.Log("c: " + c);
    }
}
