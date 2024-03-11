using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public void Pause()
    {
        GameManager.Instance.ChangeState(GameState.Pause);
        this.gameObject.SetActive(false);
    }    
}
