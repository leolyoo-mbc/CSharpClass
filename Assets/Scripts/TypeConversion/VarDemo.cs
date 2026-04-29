using UnityEngine;

public class VarDemo : MonoBehaviour
{
    void Start()
    {
        var name = "홍길동";
        Debug.Log(name);
        Debug.Log("name 타입: " + name.GetType());

        var version = 8.0;
        Debug.Log(version);
        Debug.Log("version 타입: " + version.GetType());

        var car = 100;
        Debug.Log("car 타입: " + car.GetType());

    }
}
