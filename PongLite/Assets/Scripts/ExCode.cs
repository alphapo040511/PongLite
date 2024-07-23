using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCode : MonoBehaviour
{
    public int Level = 10;                      //int(정수) Level(변수 이름)을 선언하고 10 값을 넣어줌
    public float Hp = 100.0f;                   //float(실수) Hp(변수 이름)을 선언하고 100 값을 넣어줌
    public bool IsDead = false;                 //bool(참/거짓) IsDead(변수 이름)을 선언하고 false 값을 넣어줌
    public string PlayerName = "이름";          //string(문자열) PlayerName(변수 이름)을 선언하고 이름 값을 넣어줌

    //나중에 추가
    public float Damage = 12.5f;                //데미지 값 선언




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("이름 : " + PlayerName + " 레벨 : " + Level + " Hp : " + Hp);

        //한 중간에 추가

        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i + " 번째 순번 입니다. ");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //나중에 추가

        //if(Input.GetKeyDown(KeyCode.Alpha1))                        //숫자 1 버튼이 눌렸을 때
        //{ 
        //    Attack(Damage);                                         //Attack 함수 사용
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha2))                       //숫자 2 버튼이 눌렸을 때
        //{
        //    if(Hp > 0)                                              //Hp가 0 보다 크면
        //    {
        //        Debug.Log("현재 Hp 는 : " + Hp + " 입니다.");       //현재 Hp 출력
        //    }
        //    else if(Hp <= 0)                                        //Hp 가 0 보다 작거나 같다면
        //    {
        //        Debug.Log("죽었습니다.");
        //    }
        //}
    }

    void Attack(float Damage)               //데미지 함수 선언 (매개변수)
    {
        Hp = Hp - Damage;                   //데미지 감소

        //위에 주석 처리후 변경
        //Hp -= Damage;
    }
}
