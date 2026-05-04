using UnityEngine;

//숫자 데이터 형식 사용하기: 정수형, 실수형
public class IntegerDemo : MonoBehaviour
{
    void Start()
    {
        //SignedInteger: 부호(+, -)가 있는 정수형
        Debug.Log("sbyte: " + sbyte.MaxValue);
        Debug.Log("short: " + short.MaxValue);
        Debug.Log("int: " + int.MaxValue);
        Debug.Log("long: " + long.MaxValue);

        //UnsignedInteger: 부호가 없는 정수형
        Debug.Log("byte: " + byte.MaxValue);
    }
}

/*
1Byte = 8bit
1비트: 0, 1 데이터를 저장하는 단위

8비트(sbyte)

==> -128 ~ 127
10000000 ==> -128
.
.
.
11111110 ==> -2
11111111 ==> -1
00000000 ==> 0
00000001 ==> 1
00000010 ==> 2
00000011 ==> 3
.
.
.
01111111 ==> 127
*/