using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public Text TimeText;

    public GameObject GameOverUI;

    private bool Play = true;
    private float playTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (Play)
        {
            playTime += Time.deltaTime;

            TimeText.text = "PlayTime : " + playTime.ToString("00.00");
        }

        if(!Play)
        {
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene("GameScene");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.transform.tag == "Ball")
        {
            Destroy(collision.gameObject);
            Play = false;
            GameOverUI.SetActive(true);
        }
    }
}
