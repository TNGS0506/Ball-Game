using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    //int maxPlatform = 0;
    public NextLevelScreen nextlevel;

    public void GameOver()
    {
        GameOverScreen.Setup();
    }
    public void GameComplete()
    {
        nextlevel.Setup();
    }
}
