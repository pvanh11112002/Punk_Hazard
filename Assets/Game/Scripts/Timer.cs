using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : Singleton<Timer>
{
    //[SerializeField] TextMesh timerText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float elapsedTime = 0;
    [SerializeField] float remainingTime = 1200f;
    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.gameState == GameState.GamePlay)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                elapsedTime += Time.deltaTime;
                if (elapsedTime > 60)
                {
                    elapsedTime = 0;
                }

            }
            else if (remainingTime < 0)
            {
                remainingTime = 0;
                timerText.color = Color.red;
            }
            int minutes = Mathf.FloorToInt(remainingTime / 60);
            int seconds = Mathf.FloorToInt(remainingTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }    
        
    }
}
