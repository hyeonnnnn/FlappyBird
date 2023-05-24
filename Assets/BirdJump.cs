using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 유니티 UI 이용

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // 리지드바디2D 클래스를 가진 변수 생성
    public float jumpPower; // 점프 세기

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 리지드바디2D 컴포넌트를 rb에 담아줌
    }

    // Update is called once per frame
    void Update() // 매 프레임마다 검사
    {
        if (Input.GetKey(KeyCode.UpArrow)) // 위 방향키 클릭 시
        {
            rb.velocity = Vector2.up * jumpPower;  // (0,jumpPower)
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.score > Score.bestScore) // 현재 점수가 최고 점수보다 높으면
        {
            Score.bestScore = Score.score; // 현재 점수를 최고 점수로
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
