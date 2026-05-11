using UnityEngine;

public class ClassDemo : MonoBehaviour
{
    public class InnerClassDemo
    {
        public static void StaticMethod()
        {
            Debug.Log("정적 메서드");
        }

        public void InstanceMethod()
        {
            Debug.Log("인스턴스 메서드");
        }
    }

    void Start()
    {
        InnerClassDemo.StaticMethod();
        InnerClassDemo innerClass = new InnerClassDemo();
        innerClass.InstanceMethod();
    }
}
