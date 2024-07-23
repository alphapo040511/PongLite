using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                           //유니티 UI 사용을 위한 라이브러리 선언
using UnityEngine.SceneManagement;              //유니티 씬 전환을 위한 라이브러리 선언

public class Goal : MonoBehaviour
{
    public Text TimeText;                       //Text UI

    public GameObject BallPrefabs;              //공 오브젝트의 Prefabs
    public GameObject GameOverUI;               //게임종료 UI

    private bool ballExists = false;            //현재 씬에 공이 존재하는지 확인하는 bool 변수
    private bool Play = true;                   //현재 게임이 진행중인지 확인하는 bool 변수
    private float playTime = 0;                 //게임 진행시간

    void Start()
    {
        ballExists = false;                     //시작될때 한번더 변수 초기화
        playTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ballExists == false)                                                         //현재 씬에 공이 없을때
        {
            if(Input.anyKeyDown)                                                        //아무키나 누르면
            {
                ballExists = true;                                                      //현재 공의 존재 여부 true로 변경
                Instantiate(BallPrefabs, new Vector2(0, 3), Quaternion.identity);       //공을 동적으로 생성
            }
        }

        if (Play && ballExists == true)                                                 //플레이중이고, 공이 존재할 때
        {
            playTime += Time.deltaTime;                                                 //플레이 시간을 추가

            TimeText.text = "PlayTime : " + playTime.ToString("00.00");                 //시간 UI에 현재 시간을 표시
        }

        if(!Play)                                                                       //플레이중이 아닐때
        {
            if(Input.anyKeyDown)                                                        //아무키나 누르면
            {
                SceneManager.LoadScene("GameScene");                                    //현재 씬(GameScene)을 다시 로드 함
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)                              //다른 물체랑 충돌 했을때
    {
        if(collision.transform.tag == "Ball")                                           //충돌한 물체의 tag 가 Ball 이면
        {
            Destroy(collision.gameObject);                                              //충돌한 물체를 삭제
            Play = false;                                                               //플레이중 false로 변경
            GameOverUI.SetActive(true);                                                 //게임 오버 UI 활성화
        }
    }
}
