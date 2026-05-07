using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    private void Start()
    {
        //크기3의 정수형 배열 {1, 2, 3} 만들기
        int[] arr = { 1, 2, 3 };

        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }

        int index = 0;
        Debug.Log(arr[index++]);
        Debug.Log(arr[index++]);
        Debug.Log(arr[index++]);
        Debug.Log(arr[--index]);
        Debug.Log(arr[--index]);
        Debug.Log(arr[--index]);

        string str = "C#8";
        Debug.Log(str[0]);
        Debug.Log(str[1]);
        Debug.Log(str[2]);
        Debug.Log($"문자열의 길이: {str.Length}");
    }
}
