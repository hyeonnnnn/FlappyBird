using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCoin : MonoBehaviour
{
    public GameObject coin; // GameObject �ڷ����� coin ���� ����
                            // prefab�� coin ���� �ȿ� �ֱ� ����
    float timer = 0; // Ÿ�̸�
    public float timediff; // �ð� ����

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // timer�� 1 == 1�ʰ� �帥 ��
        if ( timer > timediff ) // timediff�ʰ� �帥 ������
        {
            GameObject newcoin = Instantiate(coin); // prefab ���� newcoin ���� ����
            newcoin.transform.position = new Vector3(9, Random.Range(0, 2f), 5f); // y��ǥ �����ϰ� ����
            timer = 0;
            Destroy(newcoin, 10.0f); // 10�� �ڿ� coin ����
        }
    }
}
