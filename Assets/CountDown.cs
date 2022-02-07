using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public int timeRemaining;
    public Text countDownMsg;

    private void Start()
    {
        // Starts the timer automatically
        countDownMsg.text = "";
        countDownMsg.gameObject.SetActive(true);
        StartCoroutine(CountDownTimer());
    }
    
    IEnumerator CountDownTimer()
    {
        while(timeRemaining > 0)
        {
            countDownMsg.text = timeRemaining.ToString();

            yield return new WaitForSeconds(1f);

            timeRemaining--;
        }

        countDownMsg.text = "Play!";

        yield return new WaitForSeconds(1f);

        countDownMsg.gameObject.SetActive(false);


    }


}
