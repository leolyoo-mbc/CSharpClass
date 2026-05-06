using UnityEngine;

public class JumpDemo : MonoBehaviour
{
    private void Start()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            if (sum >= 22)
            {
                break;
            }
        }
        Debug.Log($"합: {sum}");

        sum = 0;

        for (int j = 1; j <= 100; j++)
        {
            if (j % 3 == 0)
            {
                continue;
            }
            sum += j;
        }
        Debug.Log($"합: {sum}");
    }
}
