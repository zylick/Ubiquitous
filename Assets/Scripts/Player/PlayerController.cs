// Author: Robbie Carrington Jr.

using UnityEngine;

public class PlayerController : MonoBehaviour {

    const int MAX_HUMANS_KILLED = 50; // holds the maximum number of humans we can kill before game is over

    public int Score; // holds the score of the player
    public int HumansKilled; // holds the number of humans the player has killed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (IsDead())
        {
            // Player is dead, so process Game Over
        }
	}

    /// <summary>
    /// Checks whether the player is dead. Based on HumansKilled or Score reaches 0
    /// </summary>
    /// <returns>true if score is 0 or less or HumansKilled is above the maximum numbers of humans that can be killed</returns>
    public bool IsDead()
    {
        if (Score <= 0 || HumansKilled > MAX_HUMANS_KILLED)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Increments the number of humans killed
    /// </summary>
    /// <param name="value">An Int value that holds how much to raise the number of humans killed</param>
    public void IncrementHumansKilled(int value)
    {
        HumansKilled += value;
    }

    /// <summary>
    /// Incremenets the player's score
    /// </summary>
    /// <param name="value">An Int value that holds how much we should raise the score</param>
    public void IncrementScore(int value)
    {
        Score += value;
    }

    /// <summary>
    /// Decrements the score
    /// </summary>
    /// <param name="value">An Int value that holds how much we should lower the score</param>
    public void DecrementScore(int value)
    {
        Score -= value;
    }
}
