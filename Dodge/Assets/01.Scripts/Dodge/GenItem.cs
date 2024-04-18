using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenItem : MonoBehaviour
{
    public GameObject item;             // ���� ������Ʈ ������ ����
    public float checkTime;             // �ð��� üũ ����

    void Update()
    {
        checkTime += Time.deltaTime;    // �� ������ �ð��� ���ؼ� �׾Ƽ�  
        if (checkTime > 2.5f)           // 2�ʰ� ��������
        {
            GameObject Temp = Instantiate(item);        // ������Ʈ�� �����ϴ� �Լ� <Instantiate>, GameObject�� ���Ƿ� ������ Temp ���� �����Ѵ�.
            Temp.transform.position += new Vector3(Random.Range(0, 8), 0.0f, Random.Range(0, 8)); // �������� 0,3�� ������ ��ġ�� �ٲ��ش�.
            Destroy(Temp, 20.0f);       // ������Ʈ�� 20���Ŀ� �ı�
            checkTime = 0.0f;           // 2�ʸ��� �������� �����ϱ����ؼ� �ʱ�ȭ
        }
    }
}
