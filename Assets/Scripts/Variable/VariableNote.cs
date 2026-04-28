using UnityEngine;

//변수(Variable): 프로그램에서 사용할 데이터를 저장해 놓는 그릇
public class VariableNote : MonoBehaviour
{
    void Start()
    {
        //[1] 변수 만들기
        int i; //i 이름으로 정수형 변수를 만든다.

        //[2] 변수에 값을 저장하기
        i = 1234;

        //[3] 변수 들어있는 값을 사용하기
        Debug.Log(i);
    }
}
