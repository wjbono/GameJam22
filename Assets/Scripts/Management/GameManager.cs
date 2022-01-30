using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    CanvasSwitcher cSwitcher;

    public enum UserChoice
    {
        STAND_UP,
        FIND_OUTLET,
        MAKE_FRIENDS
    }

    public enum Result
    {
        SAD,
        GOOD,
        EXTREME
    }

    const int oneHundredPercent = 7;
    UserChoice choice;
    CameraFocus cf;

    // Start is called before the first frame update
    void Start()
    {
        cf = Camera.main.GetComponent<CameraFocus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetChoice(UserChoice userChoice)
    {
        choice = userChoice;
    }

    public void ShowResult(int loops)
    {
        float percentage = (float)loops / (float)oneHundredPercent;
        if (percentage <= 0.25f)
        {
            ShowEnd(Result.SAD);
        }
        else if (percentage >= 0.75f)
        {
            ShowEnd(Result.EXTREME);
        }
        else
        {
            ShowEnd(Result.GOOD);
        }
    }

    void ShowEnd(Result result)
    {
        if (result == Result.SAD)
        {

        }
    }
}