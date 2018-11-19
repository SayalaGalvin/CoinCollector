using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript2 : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D col)
    {


        Score2.coinAmount += 1;
        Destroy(gameObject);

    }
}
