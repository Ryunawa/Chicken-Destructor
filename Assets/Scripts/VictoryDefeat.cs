using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryDefeat : MonoBehaviour
{
    public int ChickenMax;
    public int ChickenRemaining;

    // Start is called before the first frame update
    void Start()
    {
        ChickenMax = 20;
        ChickenRemaining = ChickenMax;
    }

    public void DecrementChicken()
    {
        ChickenRemaining--;
        if (ChickenRemaining <= 0)
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
        print("Congrats ! You killed all the chickens ! But... why ?");
    }

}
