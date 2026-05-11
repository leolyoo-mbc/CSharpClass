using UnityEngine;

public class RandomPractice : MonoBehaviour
{
    void Start()
    {
        //첫번째 방법: O(n^2)
        int[] numbers = new int[6];

        //6개의 중복 없는 임의의 정수 생성
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(1, 46);
            //이전 인덱스의 숫자들과 비교하고 같으면 재반복
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    i--;
                    break;
                }
            }
        }

        //모든 정수 출력
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }


        ////두번째 방법: O(n)
        //int[] allNumbers = new int[45];

        ////1~45의 정수 배열에 담기
        //for (int i = 0; i < 45; i++)
        //{
        //    allNumbers[i] = i + 1;
        //}

        ////배열 랜덤하게 섞기
        //for (int i = 0; i < allNumbers.Length; i++)
        //{
        //    int randomIndex = Random.Range(0, 45);
        //    int temp = allNumbers[i];
        //    allNumbers[i] = allNumbers[randomIndex];
        //    allNumbers[randomIndex] = temp;
        //}
        ////앞에서부터 6개 정수 출력
        //for (int i = 0; i < 6; i++)
        //{
        //    Debug.Log(allNumbers[i]);
        //}
    }
}
