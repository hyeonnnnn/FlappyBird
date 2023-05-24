using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ����Ƽ UI �̿�

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // ������ٵ�2D Ŭ������ ���� ���� ����
    public float jumpPower; // ���� ����

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ������ٵ�2D ������Ʈ�� rb�� �����
    }

    // Update is called once per frame
    void Update() // �� �����Ӹ��� �˻�
    {
        if (Input.GetKey(KeyCode.UpArrow)) // �� ����Ű Ŭ�� ��
        {
            rb.velocity = Vector2.up * jumpPower;  // (0,jumpPower)
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(Score.score > Score.bestScore) // ���� ������ �ְ� �������� ������
        {
            Score.bestScore = Score.score; // ���� ������ �ְ� ������
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
