using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCode : MonoBehaviour
{
    public int Level = 10;                      //int(����) Level(���� �̸�)�� �����ϰ� 10 ���� �־���
    public float Hp = 100.0f;                   //float(�Ǽ�) Hp(���� �̸�)�� �����ϰ� 100 ���� �־���
    public bool IsDead = false;                 //bool(��/����) IsDead(���� �̸�)�� �����ϰ� false ���� �־���
    public string PlayerName = "�̸�";          //string(���ڿ�) PlayerName(���� �̸�)�� �����ϰ� �̸� ���� �־���

    //���߿� �߰�
    public float Damage = 12.5f;                //������ �� ����




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�̸� : " + PlayerName + " ���� : " + Level + " Hp : " + Hp);

        //�� �߰��� �߰�

        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i + " ��° ���� �Դϴ�. ");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //���߿� �߰�

        //if(Input.GetKeyDown(KeyCode.Alpha1))                        //���� 1 ��ư�� ������ ��
        //{ 
        //    Attack(Damage);                                         //Attack �Լ� ���
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha2))                       //���� 2 ��ư�� ������ ��
        //{
        //    if(Hp > 0)                                              //Hp�� 0 ���� ũ��
        //    {
        //        Debug.Log("���� Hp �� : " + Hp + " �Դϴ�.");       //���� Hp ���
        //    }
        //    else if(Hp <= 0)                                        //Hp �� 0 ���� �۰ų� ���ٸ�
        //    {
        //        Debug.Log("�׾����ϴ�.");
        //    }
        //}
    }

    void Attack(float Damage)               //������ �Լ� ���� (�Ű�����)
    {
        Hp = Hp - Damage;                   //������ ����

        //���� �ּ� ó���� ����
        //Hp -= Damage;
    }
}
