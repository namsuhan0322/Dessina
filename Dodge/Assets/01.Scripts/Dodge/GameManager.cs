using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // UI ���� ���̺귯��
using UnityEngine.SceneManagement;  // �� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public int Point = 0;

    public GameObject gameover_text;       // ���� ���� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text time_text;                  // ���� �ð�
    public Text record_text;                // ���ӿ��� ����
    public Text score_text;

    public static int itemAcount;

    private float survive_time;             // ���� �ð�
    bool is_gamaover;                       //

    void Start()
    {
        survive_time = 0;
        is_gamaover = false;
    }

    void Update()
    {
        // ���� ������ �ƴ� ����
        if (!is_gamaover)
        {
            // ���� �ð� ����
            survive_time += Time.deltaTime;
            // ������ ���� �ð��� time_text �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
            time_text.text = "TIme" + (int)survive_time;

            score_text.text = "Score : " + itemAcount.ToString();
        }
        else
        {
            // ���� ������ ���¿��� RŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                // Dodge �� �ε�
                SceneManager.LoadScene("Dodge_scene");
            }
        }
    }

    public void EndGame()
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        is_gamaover = true;
        // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameover_text.SetActive(true);

        /*// Best_time Ű�� ����� ���������� �ְ� ��� ��������
        float best_time = PlayerPrefs.GetFloat("Best_time");

        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (survive_time > best_time)
        {
            // �ְ� ��� ���� ���� ���� �ð� ������ ����
            best_time = survive_time;
            // ����� �ְ� ��α�Best_time Ű�� ����
            PlayerPrefs.SetFloat("Best_time", best_time);
        }

        // �ְ� ����� record_text ������Ʈ�� �̿��� ǥ��
        record_text.text = "Best_Time: " + (int)best_time;*/
    }
}
