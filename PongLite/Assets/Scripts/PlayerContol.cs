using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContol : MonoBehaviour
{
    public float Speed = 5.0f;


    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))                                       //위 화살표를 누르고 있을때
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);           //위로 이동  (델타 타임은 추후에 추가)
        }

        if (Input.GetKey(KeyCode.DownArrow))                                    //아래 화살표를 누르고 있을때
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);         //아래로 이동  (델타 타임은 추후에 추가)
        }

        if(transform.position.y > 3.5f)
        {
            transform.position = new Vector2(transform.position.x, 3.5f);
        }

        if (transform.position.y < -3.5f)
        {
            transform.position = new Vector2(transform.position.x, -3.5f);
        }
    }
}
