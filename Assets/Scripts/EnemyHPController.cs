using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPController : MonoBehaviour
{
    int enemyHP = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damage()
    {
        enemyHP--;

        Debug.Log("敵の体力:" + enemyHP);

        if (enemyHP == 0)
        {
            ScoreCounter.destroyedEnemyCount++;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            other.gameObject.SendMessage("playerDamage");
            Destroy(this.gameObject);
        }
    }
}
