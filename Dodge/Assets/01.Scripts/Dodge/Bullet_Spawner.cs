using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner : MonoBehaviour
{
    public GameObject bullet_prefab;        // ������ ź���� ���� ������
    public float spqwn_rate_min = 0.5f;      // �ּ� ���� �ֱ�
    public float spqwn_rate_max = 3f;      // �ִ� ���� �ֱ�

    Transform target;   // �߻��� ���
    float spawn_rate;   // ���� �ֱ�
    float time_after_spawn; // �ֱ� ���� �������� ���� �ð�

    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        time_after_spawn = 0;

        // ź�� ���� ������ spqwn_rate_min�� spqwn_rate_max ���̿��� ���� ����
        spawn_rate = Random.Range(spqwn_rate_min, spqwn_rate_max);

        // Player_controller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<Player_controller>().transform;   // ���� �����ϴ� ��� ������Ʈ���� �˻��Ͽ� ������ Ÿ�԰� ��ġ�� ������Ʈ�� �������� �ű� ������ ������ �����ų ��� ���α׷��� �ɰ��ϰ� ���������ֽ��ϴ�.
        // FindObjectOfType �޼���� ������ Ÿ���� ������Ʈ�� �������̰� �� ������Ʈ���� ������ �� ���ȴ�.
    }

    void Update()
    {
        // time_after_spawn ����
        time_after_spawn += Time.deltaTime; // time_after_spawn =  time_after_spawn + Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (time_after_spawn > spawn_rate)
        {
            // ������ �ð��� ����
            time_after_spawn = 0;

            // bullet_prefab�� ��������
            // transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bullet_prefab, transform.position, transform.rotation);
            // ������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);

            // ������ ���� ������ spqwn_rate_min, spqwn_rate_max ���̿��� ���� ����
            spawn_rate = Random.Range(spqwn_rate_min, spqwn_rate_max);
        }
    }
}
