using UnityEngine;

public class ControlStatement : MonoBehaviour
{
    public int score = 0;
    public int num = 0;
    public int answer = 0;

    void Start()
    {
        if (score >= 90)
            Debug.Log("학점: A");
        else if (score >= 80)
            Debug.Log("학점: B");
        else if (score >= 70)
            Debug.Log("학점: C");
        else if (score >= 60)
            Debug.Log("학점: D");
        else
            Debug.Log("학점: F");

        if (num == 0)
        {
            Debug.Log("num은 3, 5, 7의 배수가 아닌 수");
        }
        else if (num % 3 == 0)
        {
            Debug.Log("num은 3의 배수");
        }
        else if (num % 5 == 0)
        {
            Debug.Log("num은 5의 배수");
        }
        else if (num % 7 == 0)
        {
            Debug.Log("num은 7의 배수");
        }
        else
        {
            Debug.Log("num은 3, 5, 7의 배수가 아닌 수");
        }

        switch (answer)
        {
            case 1:
                Debug.Log("1번 답을 선택했습니다.");
                break;
            case 2:
                Debug.Log("2번 답을 선택했습니다.");
                break;
            case 3:
                Debug.Log("3번 답을 선택했습니다.");
                break;
            case 4:
                Debug.Log("4번 답을 선택했습니다.");
                break;
            default:
                Debug.Log("잘못 선택했습니다.");
                break;
        }

        if (answer == 1)
        {
            Debug.Log("1번 답을 선택했습니다.");
        }
        else if (answer == 2)
        {
            Debug.Log("2번 답을 선택했습니다.");
        }
        else if (answer == 3)
        {
            Debug.Log("3번 답을 선택했습니다.");
        }
        else if (answer == 4)
        {
            Debug.Log("4번 답을 선택했습니다.");
        }
        else
        {
            Debug.Log("잘못 선택했습니다.");
        }
    }
}
