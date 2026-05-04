using UnityEngine;

public class IncrementNumber : MonoBehaviour
{
    void Start()
    {
        int i = 1;
        int j = 2;
        i += j;
        Debug.Log($"i: {i}");
        i -= j;
        Debug.Log($"i: {i}");
    }
}
