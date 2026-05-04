using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    void Start()
    {
        Debug.Log("AND");
        Debug.Log(true && true);
        Debug.Log(true && false);
        Debug.Log(false && true);
        Debug.Log(false && false);
        Debug.Log("OR");
        Debug.Log(true || true);
        Debug.Log(true || false);
        Debug.Log(false || true);
        Debug.Log(false || false);
        Debug.Log("NOT");
        Debug.Log(!true);
        Debug.Log(!false);
        Debug.Log("XOR");
        Debug.Log(true ^ true);
        Debug.Log(true ^ false);
        Debug.Log(false ^ true);
        Debug.Log(false ^ false);
    }
}
