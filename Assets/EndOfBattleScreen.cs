using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOfBattleScreen : MonoBehaviour
{
    public float playerHealth;
    public float enemyHealth;

    public GameObject endScreen;
    public Text endText;


    void Start()
    {
        endScreen.SetActive(false);
    }
    // Update is called once per frame
    
    public void OnDeath()
    {
            
        endScreen.SetActive(true);
        Debug.Log("Display that he Lost, Change Scene");
        endText.text = "You Have Lost!";
    }

    private void BattleWon()
    {
        endScreen.SetActive(true);
        Debug.Log("Display that he Won, Dancing Animation ");
        endText.text = "You Have Won!";
    }


    public void KillPlayer()
    {
        playerHealth = 0;
        OnDeath();
    }

    public void KillEnemy()
    {
        enemyHealth = 0;
        BattleWon();
    }


    public void ReturnToWorldMap()
    {
        SceneManager.LoadScene("WorldMap");
    }



}
