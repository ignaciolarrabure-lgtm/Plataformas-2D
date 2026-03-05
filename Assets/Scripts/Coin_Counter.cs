using UnityEngine;
using TMPro;

public class Coin_Counter : MonoBehaviour
{
    public static Coin_Counter instance;
    public TMP_Text Coin_Text;
    public int Current_Coins = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Coin_Text.text = "Coins : " + Current_Coins.ToString();
    }

    public void Increase_Coins(int v)
    {
        Current_Coins += v;
        Coin_Text.text = "Coins : " + Current_Coins.ToString();

    }





}


