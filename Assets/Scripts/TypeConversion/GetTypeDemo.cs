using UnityEngine;

public class GetTypeDemo : MonoBehaviour
{
    void Start()
    {
        int i = 1234;
        string s = "안녕하세요";
        char c = 'a';
        double d = 3.14;

        Debug.Log(i.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
        Debug.Log(d.GetType());
    }
}
