using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHPController : MonoBehaviour
{
    public Text playerHPText;
    int playerHP = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playerDamage()
    {
        playerHP--;

        Debug.Log("プレイヤーの体力:" + playerHP);

        playerHPText.text = "PlayerHP: " + playerHP;

        if (playerHP == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
