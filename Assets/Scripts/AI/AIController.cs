//Author: Robbie Carrington Jr.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All the bonus types we have
public enum BonusTypes { KILLHUMANS, SCOREPLUS, SCOREMINUS }

public class AIController : MonoBehaviour {

    public BonusTypes BonusType = BonusTypes.KILLHUMANS; // the BonusTypes variable
    public int HP = 1; // holds the Health Points of this AI, usually 1

    public int bonusValue = 1; // holds the amount of bonus to give from the bonus types

	// Use this for initialization
	void Start () {
        executeBonus(); // give out bonus to player when object comes into player
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// This function will give out a bonus (good or bad) to the player depending on the value of BonusType
    /// </summary>
    private void executeBonus()
    {
        GameObject player = GameObject.FindGameObjectWithTag("player");
        switch (BonusType)
        {
            case BonusTypes.KILLHUMANS:
                player.GetComponent<PlayerController>().IncrementHumansKilled(bonusValue);
                break;
            case BonusTypes.SCOREPLUS:
                player.GetComponent<PlayerController>().IncrementScore(bonusValue);
                break;
            case BonusTypes.SCOREMINUS:
                player.GetComponent<PlayerController>().DecrementScore(bonusValue);
                break;
            default:
                break;
        }
    }
}
