using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Text text;
    public GameObject gameover;
    public AudioSource adsou;
    public AudioSource stop;
    public static int coinAmount;
    // Use this for initialization
    public void Start()
    {
        text = GetComponent<Text>();
       
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
        if (coinAmount == 8)
        {
            gameover.SetActive(true);
            adsou.Play();
            stop.Stop();
        }
    }
}
