using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Image slider;
    public Text chickenRemaining;
    public Text chickenMax;

    public void SetHealthBar(float health)
    {
        slider.fillAmount = health / 100.0f;
    }
    
    public void SetCounterChicken(int count)
    {
        chickenRemaining.GetComponent<Text>().text = "" + count;
    }
    public void SetMaxChicken(int max)
    {
        chickenMax.GetComponent<Text>().text = "" + max;
    }

}
