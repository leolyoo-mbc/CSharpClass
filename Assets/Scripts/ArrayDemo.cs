using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    void Start()
    {
        //크기3의 정수형 배열 {1, 2, 3} 만들기
        int[] arr = { 1, 2, 3 };

        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }
}
