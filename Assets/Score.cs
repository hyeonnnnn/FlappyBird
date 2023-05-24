using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro 사용

public class Score : MonoBehaviour
{
    public static int score = 0; // 점수
                                 // 인스턴스 생성 없이 클래스에서 변수 관리: static
    public static int bestScore = 0;

    private TMP_Text scoreText; // TextMeshPro의 TMP_Text 타입 변수

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>(); // TextMeshPro 컴포넌트 가져오기
        score = 0; // 시작할 때마자 점수 초기화
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString(); // score는 int, text는 string
                                           // .Tostring을 통해 score을 string으로
    }
}
