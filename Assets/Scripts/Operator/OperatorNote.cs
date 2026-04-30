using UnityEngine;

public class OperatorNote : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello" + " " + "World");
        //Debug.Log("Hello" - "World");//Error

        Debug.Log("123" + 456);//123456
        Debug.Log(123 + 456);//579
        Debug.Log(123 + "456" + 789 + 890);//123456789890
        Debug.Log("123" + true);//123True

        int i = 100;
        int j = 200;
        Debug.Log($"i: {i}\nj: {j}");
        j = j - i;
        i = i + j;
        Debug.Log($"i: {i}\nj: {j}");
    }
}
