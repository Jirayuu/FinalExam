using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pickup_coin : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "coin")
        {
            coin = coin + 5;
            textCoins.text = ("Score: ") + coin.ToString();
            Destroy(other.gameObject);
        }
        if (other.transform.tag == "met")
        {
            coin = coin - 1;
            textCoins.text = ("Score: ") + coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
