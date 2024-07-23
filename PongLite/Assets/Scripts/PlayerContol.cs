using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContol : MonoBehaviour
{
    public float Speed = 5.0f;


    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))                                       //�� ȭ��ǥ�� ������ ������
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);           //���� �̵�  (��Ÿ Ÿ���� ���Ŀ� �߰�)
        }

        if (Input.GetKey(KeyCode.DownArrow))                                    //�Ʒ� ȭ��ǥ�� ������ ������
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);         //�Ʒ��� �̵�  (��Ÿ Ÿ���� ���Ŀ� �߰�)
        }

        if(transform.position.y > 3.5f)                                         //�÷��̾��� y ��ǥ�� 3.5���� ������
        {
            transform.position = new Vector2(transform.position.x, 3.5f);       //�÷��̾��� y ��ǥ�� 3.5�� �̵�
        }

        if (transform.position.y < -3.5f)                                       //�÷��̾��� y ��ǥ�� -3.5���� ������
        {
            transform.position = new Vector2(transform.position.x, -3.5f);      //�÷��̾��� y ��ǥ�� -3.5�� �̵�
        }
    }
}
