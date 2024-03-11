using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.Instance.ChangeState(GameState.GamePlay);
        this.gameObject.SetActive(false);
    }
}
