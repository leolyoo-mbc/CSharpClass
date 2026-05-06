using UnityEngine;

public class LoopDemo : MonoBehaviour
{
    public int n = 100;

    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
        }
        Debug.Log($"1이상 {n}이하의 정수 중 짝수의 합은 {sum}이다.");

        int fact = 1;
        for (int j = n; j > 0; j--)
        {
            fact = fact * j;
        }
        Debug.Log($"{n}! = {fact}");

        sum = 0;
        int k = 1;
        while (k <= n)
        {
            sum = sum + k;
            k++;
        }
        Debug.Log($"{k}부터 {n}까지의 합은: {sum}");

        int l = 0;
        do
        {
            Debug.Log(l);
            l++;
        } while (l < 5);


        //1~100 중 3의 배수 또는 4의 배수를 구해서 합하기
        sum = 0;
        int m = 1;
        while (m <= 100)
        {
            if (m % 3 == 0 || m % 4 == 0)
            {
                sum = sum + m;
            }
            m++;
        }
        Debug.Log($"1~100 중 3의 배수 또는 4의 배수의 합: {sum}");
    }
}
