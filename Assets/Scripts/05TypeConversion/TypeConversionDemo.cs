using UnityEngine;

public class TypeConversionDemo : MonoBehaviour
{
    void Start()
    {
        //long l = long.MaxValue;
        //Debug.Log($"l: {l}");

        //int i = (int)l;//명시적 형변환
        //Debug.Log($"i: {i}");

        double d = 12.34;//실수형 64비트
        int i = 1234;//정수형 32비트

        //d = i;//암묵적 형변환
        //Debug.Log($"d: {d}");

        string s = "";
        s = d.ToString();
        Debug.Log($"s: {s}");
        s = i.ToString();
        Debug.Log($"s: {s}");
    }
}
