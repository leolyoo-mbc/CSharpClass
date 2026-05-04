using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    void Start()
    {
        float f = 3.14f;
        Debug.Log(f);

        double d = 3.141592d;//d 생략 가능
        Debug.Log(d);

        decimal m = 3.1415926535897932384626433832m;
        Debug.Log(m);

    }
}
/*
 * float: 32비트 실수형
 * double: 64비트 실수형
 * decimal: 128비트 실수형
 */