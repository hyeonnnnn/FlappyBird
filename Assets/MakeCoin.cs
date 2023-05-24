using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCoin : MonoBehaviour
{
    public GameObject coin; // GameObject 자료형인 coin 변수 생성
                            // prefab을 coin 변수 안에 넣기 위해
    float timer = 0; // 타이머
    public float timediff; // 시간 간격

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // timer가 1 == 1초가 흐른 것
        if ( timer > timediff ) // timediff초가 흐른 시점에
        {
            GameObject newcoin = Instantiate(coin); // prefab 찍어내는 newcoin 변수 생성
            newcoin.transform.position = new Vector3(9, Random.Range(0, 2f), 5f); // y좌표 랜덤하게 설정
            timer = 0;
            Destroy(newcoin, 10.0f); // 10초 뒤에 coin 삭제
        }
    }
}
