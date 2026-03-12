using UnityEngine;
using TMPro;

public class Coin_Counter : MonoBehaviour
{
    public static Coin_Counter instance;
    public TMP_Text Coin_Text;
    public int Current_Coins = 0;

    [Header("Door configuration")]
    public int Total_Coins_In_Level; 
    public GameObject Door_To_Destroy; 

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Total_Coins_In_Level = GameObject.FindObjectsByType<Coin_Collected>(FindObjectsSortMode.None).Length;

        Update_UI();
    }

    public void Increase_Coins(int v)
    {
        Current_Coins += v;
        Update_UI();

        if (Current_Coins >= Total_Coins_In_Level)
        {
            Unlock_Door();
        }
    }

    void Update_UI()
    {
        Coin_Text.text = "Coins : " + Current_Coins.ToString();
    }

    void Unlock_Door()
    {
        if (Door_To_Destroy != null)
        {
            Destroy(Door_To_Destroy);
            Debug.Log("Door opened");
        }
    }
}


