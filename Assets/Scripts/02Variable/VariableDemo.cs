using UnityEngine;

public class VariableDemo : MonoBehaviour
{
    void Start()
    {
        //[1] 변수 선언과 동시에 초기화
        int number = 7;
        Debug.Log(number);

        //[2] 여러 개의 변수를 한 줄에서 선언하기
        /*
        int number1;
        int number2;
        int number3;
        */
        int number1, number2, number3;
        number1 = 1;
        number2 = 2;
        number3 = 3;
        Debug.Log(number1 + ", " + number2 + ", " + number3);

        //[3] 여러 개의 변수를 한 줄에서 선언 & 초기화
        int a, b, c;
        a = b = c = 10;
        Debug.Log(a + ", " + b + ", " + c);
    }
}
