using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text moneyText;
    public int playerMoney = 100000;

    

    // Start is called before the first frame update
    void Start()
    {
        UpdateMoney();
    }

    // Update is called once per frame

    public void AddMoney(int value)
    {
        playerMoney += value;
        UpdateMoney();
    }

    public void SubtractMoney(int value)
    {
        playerMoney -= value;
        UpdateMoney();
    }

    private void UpdateMoney()
    {
        moneyText.text = playerMoney.ToString();
    }

}
