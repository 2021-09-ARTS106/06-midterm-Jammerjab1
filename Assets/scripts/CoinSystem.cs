using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public GameObject coinText;
    public static int theScore;

    void Update()
    {
        coinText.GetComponent<Text>().text = "COINS: " + theScore;

    }

}
