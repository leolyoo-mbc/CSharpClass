using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    public int a = 0;
    public int b = 0;

    private void ShowMessage(string message)
    {
        Debug.Log(message);
    }

    private string GetString()
    {
        return "Hello World";
    }

    private int GetMin(int num1, int num2)
    {
        return num1 < num2 ? num1 : num2;
    }

    private int GetMax(int num1, int num2)
    {
        return num1 > num2 ? num1 : num2;
    }

    private int Abs(int num)
    {
        return num < 0 ? -num : num;
    }

    private int Plus(int num1, int num2)
    {
        return num1 + num2;
    }

    private int Minus(int num1, int num2)
    {
        return num1 - num2;
    }

    private int Multifly(int num1, int num2)
    {
        return num1 * num2;
    }

    private int Divide(int num1, int num2)
    {
        return num2 != 0 ? num1 / num2 : 0;
    }

    private int Remainder(int num1, int num2)
    {
        return num2 != 0 ? num1 % num2 : 0;
    }

    private void Start()
    {
        ShowMessage(GetString());
        Debug.Log(GetMin(a, b));
        Debug.Log(GetMax(a, b));
        Debug.Log($"{a}의 절댓값: {Abs(a)}");
        Debug.Log($"{a}의 절댓값: {Mathf.Abs(a)}");
        Debug.Log(Plus(a, b));
        Debug.Log(Minus(a, b));
        Debug.Log(Multifly(a, b));
        Debug.Log(Divide(a, b));
        Debug.Log(Remainder(a, b));
    }
}
