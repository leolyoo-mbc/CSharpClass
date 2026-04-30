using UnityEngine;

public class PrefixOperator : MonoBehaviour
{
    void Start()
    {
        int i = 1;
        int j = i++;
        Debug.Log(j);
    }
}
