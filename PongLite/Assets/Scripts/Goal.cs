using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                           //����Ƽ UI ����� ���� ���̺귯�� ����
using UnityEngine.SceneManagement;              //����Ƽ �� ��ȯ�� ���� ���̺귯�� ����

public class Goal : MonoBehaviour
{
    public Text TimeText;                       //Text UI

    public GameObject BallPrefabs;              //�� ������Ʈ�� Prefabs
    public GameObject GameOverUI;               //�������� UI

    private bool ballExists = false;            //���� ���� ���� �����ϴ��� Ȯ���ϴ� bool ����
    private bool Play = true;                   //���� ������ ���������� Ȯ���ϴ� bool ����
    private float playTime = 0;                 //���� ����ð�

    void Start()
    {
        ballExists = false;                     //���۵ɶ� �ѹ��� ���� �ʱ�ȭ
        playTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ballExists == false)                                                         //���� ���� ���� ������
        {
            if(Input.anyKeyDown)                                                        //�ƹ�Ű�� ������
            {
                ballExists = true;                                                      //���� ���� ���� ���� true�� ����
                Instantiate(BallPrefabs, new Vector2(0, 3), Quaternion.identity);       //���� �������� ����
            }
        }

        if (Play && ballExists == true)                                                 //�÷������̰�, ���� ������ ��
        {
            playTime += Time.deltaTime;                                                 //�÷��� �ð��� �߰�

            TimeText.text = "PlayTime : " + playTime.ToString("00.00");                 //�ð� UI�� ���� �ð��� ǥ��
        }

        if(!Play)                                                                       //�÷������� �ƴҶ�
        {
            if(Input.anyKeyDown)                                                        //�ƹ�Ű�� ������
            {
                SceneManager.LoadScene("GameScene");                                    //���� ��(GameScene)�� �ٽ� �ε� ��
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)                              //�ٸ� ��ü�� �浹 ������
    {
        if(collision.transform.tag == "Ball")                                           //�浹�� ��ü�� tag �� Ball �̸�
        {
            Destroy(collision.gameObject);                                              //�浹�� ��ü�� ����
            Play = false;                                                               //�÷����� false�� ����
            GameOverUI.SetActive(true);                                                 //���� ���� UI Ȱ��ȭ
        }
    }
}
