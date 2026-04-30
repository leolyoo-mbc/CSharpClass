using UnityEngine;

public class RelationalOperator : MonoBehaviour
{
    void Start()
    {
        int a = 3;
        int b = 5;
        Debug.Log(a < b);//True
        Debug.Log(a <= b);//True
        Debug.Log(a > b);//False
        Debug.Log(a >= b);//False
        Debug.Log(a == b);//False
        Debug.Log(a != b);//True

        Debug.Log("AAA" == "aaa");
        Debug.Log("AAA" == "AAA");
    }
}
