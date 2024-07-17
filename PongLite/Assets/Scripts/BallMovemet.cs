using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemet : MonoBehaviour
{
    public float Speed = 5.0f;          //���� �ӵ�
    public int VerticalDirection = 1;   //���� ����
    public int HorizontalDirection = 1; //�¿� ����
    public Rigidbody2D rb;
    
    void Start()
    {
        int randomNumber = Random.Range(0, 2);              //�������� randomNumber�� 0 ~ 1 ������ ���� ������ ���� 

        if (randomNumber == 0)                              //randomNumber�� 0 �϶�
        {
            HorizontalDirection = 1;                        //���� ������ ���������� ����
        }
        else if(randomNumber == 1)                          //randomNumber�� 1 �϶�
        {
            HorizontalDirection = -1;                       //���� ������ �������� ����
        }

        VerticalDirection = 1;                              //���� ���� ������ �Ʒ��� ����

        transform.position = new Vector2(0, 3);             //���� ��ġ�� (0,0)���� �ʱ�ȭ

        rb.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }

    private void OnCollisionEnter2D(Collision2D collision)          //�ٸ� �ݶ��̴��� �浹 ������
    {
        Speed += 0.5f;

        if(collision.collider.transform.tag == "Wall")              //�浹�� ������Ʈ�� tag �� Wall �϶�
        {
            VerticalDirection *= -1;                                //���� ���� �̵� ������ ���� ��Ų��.

        }

        if (collision.collider.transform.tag == "Player")           //�浹�� ������Ʈ�� tag �� Player �϶�
        {
            HorizontalDirection *= -1;                              //���� �¿� �̵� ������ ���� ��Ų��.
        }

        rb.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }
}
