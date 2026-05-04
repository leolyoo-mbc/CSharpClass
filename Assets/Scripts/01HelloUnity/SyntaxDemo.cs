using UnityEngine;

//문법(Syntax): 어기면 에러
//코딩 컨벤션(코딩스타일): 가독성을 위한 약속
public class SyntaxDemo : MonoBehaviour
{
    void Start()
    {
        //들여쓰기
        Debug.Log("들여쓰기는 공백 4칸 또는 탭을 사용한다");

        //공백(White Space): C#에서는 공백 무시
        Debug.Log("C#");
        Debug.Log( "C#" );
        Debug.
            Log
            (
            "C#"
            );
    }

    void Update()
    {

    }
}

//주석문(Comment): 주석문은 컴파일, 실행에 영향을 주지 않는 코드
//한 줄 주석
/*
여러 줄 주석
*/