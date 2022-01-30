using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    public enum UserChoice
    {
        STAND_UP,
        FIND_OUTLET,
        MAKE_FRIENDS
    }

    UserChoice choice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetChoice(UserChoice userChoice)
    {
        choice = userChoice;
    }
}