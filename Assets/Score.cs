using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro ���

public class Score : MonoBehaviour
{
    public static int score = 0; // ����
                                 // �ν��Ͻ� ���� ���� Ŭ�������� ���� ����: static
    public static int bestScore = 0;

    private TMP_Text scoreText; // TextMeshPro�� TMP_Text Ÿ�� ����

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>(); // TextMeshPro ������Ʈ ��������
        score = 0; // ������ ������ ���� �ʱ�ȭ
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString(); // score�� int, text�� string
                                           // .Tostring�� ���� score�� string����
    }
}
