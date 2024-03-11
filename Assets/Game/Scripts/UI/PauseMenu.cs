using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public void Continue()
    {
        GameManager.Instance.ChangeState(GameState.GamePlay);
        this.gameObject.SetActive(false);
        // Load cái Ui GamePlay
    }
    public void Retry()
    {
        GameManager.Instance.ChangeState(GameState.MainMenu);
        //Load cái menu
    }
}
