using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text Money;
    private int Coin;

    void Start()
    {
       
    }
    public void Update()
    {
        Money.text = Coin.ToString();
        if (gameObject.tag == "Grown")
        {
           
            Coin += 5;
            gameObject.SetActive(false);
            Debug.Log("Money");

        }
    }

    public void Collected()
    {
       
    }
}
