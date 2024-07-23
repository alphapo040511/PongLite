using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemet : MonoBehaviour
{
    public float Speed = 5.0f;          //공의 속도
    public int VerticalDirection = 1;   //상하 방향
    public int HorizontalDirection = 1; //좌우 방향
    public Rigidbody2D rb;              //물체의 물리 적용을 위한 Rigidbody
    
    void Start()
    {
        int randomNumber = Random.Range(0, 2);              //지역변수 randomNumber에 0 ~ 1 까지의 랜덤 정수를 저장 

        if (randomNumber == 0)                              //randomNumber가 0 일때
        {
            HorizontalDirection = 1;                        //공의 방향을 오른쪽으로 설정
        }
        else if(randomNumber == 1)                          //randomNumber가 1 일때
        {
            HorizontalDirection = -1;                       //공의 방향을 왼쪽으로 설정
        }

        VerticalDirection = 1;                              //공의 상하 방향을 아래로 설정

        rb.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);
    }

    private void OnCollisionEnter2D(Collision2D collision)          //다른 콜라이더에 충돌 했을때
    {
        Speed += 0.5f;

        if(collision.transform.tag == "Wall")                       //충돌한 오브젝트의 tag 가 Wall 일때
        {
            VerticalDirection *= -1;                                //공의 상하 이동 방향을 반전 시킨다.

        }

        if (collision.transform.tag == "Player")                    //충돌한 오브젝트의 tag 가 Player 일때
        {
            HorizontalDirection *= -1;                              //공의 좌우 이동 방향을 반전 시킨다.
        }

        rb.velocity = new Vector2(Speed * HorizontalDirection, Speed * VerticalDirection);      //공의 속도를 변경
    }
}
