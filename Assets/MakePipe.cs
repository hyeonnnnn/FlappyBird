using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe; // GameObject �ڷ����� pipe ���� ����
                            // prefab�� pipe ���� �ȿ� �ֱ� ����
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
            GameObject newpipe = Instantiate(pipe); // prefab ���� newpipe ���� ����
            newpipe.transform.position = new Vector3(6, Random.Range(-3f, 1.5f), 0); // y��ǥ �����ϰ� ����
            timer = 0;
            Destroy(newpipe, 10.0f); // 10�� �ڿ� pipe ����
        }
    }
}
