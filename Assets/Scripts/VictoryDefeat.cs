using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class VictoryDefeat : MonoBehaviour
{
    public int chickenMax;
    public int chickenRemaining;
    public GameObject gameUI;

    private void Awake()
    {
        gameUI = GameObject.Find("GameInterface");
    }

    void Start()
    {
        GameObject[] chickens = GameObject.FindGameObjectsWithTag("Chicken");

        chickenMax = chickens.Count();
        chickenRemaining = chickenMax;

        gameUI.GetComponent<GameUI>().SetCounterChicken(chickenRemaining);
        gameUI.GetComponent<GameUI>().SetMaxChicken(chickenMax);
    }

    public void DecrementChicken()
    {
        chickenRemaining--;
        gameUI.GetComponent<GameUI>().SetCounterChicken(chickenRemaining);

        if (chickenRemaining <= 0)
        {
            Victory();
        }
    }

    public void Victory()
    {
        print("Congrats ! You killed all the chickens ! But... why ?");
    }

    public void Defeat()
    {
        print("You lost Robinou");
    }

}
