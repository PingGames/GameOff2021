using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text MyscoreText;
    private int ScoreNum;

    public Animator door;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
       ScoreNum = 0;
       MyscoreText.text = "Score:" + ScoreNum;  
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "MyCoin")
        {
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyscoreText.text = "Score: " + ScoreNum;
        }
        if (ScoreNum == 36)
        {
            SceneManager.LoadScene("End");
            Debug.Log("OpenDoor");
        }
    }
}
