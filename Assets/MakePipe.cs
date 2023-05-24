using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe; // GameObject 자료형인 pipe 변수 생성
                            // prefab을 pipe 변수 안에 넣기 위해
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
            GameObject newpipe = Instantiate(pipe); // prefab 찍어내는 newpipe 변수 생성
            newpipe.transform.position = new Vector3(6, Random.Range(-3f, 1.5f), 0); // y좌표 랜덤하게 설정
            timer = 0;
            Destroy(newpipe, 10.0f); // 10초 뒤에 pipe 삭제
        }
    }
}
