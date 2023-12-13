using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATM : MonoBehaviour
{
    public GameObject selectButtons;
    public GameObject depositWindow;
    public GameObject withdrawWindow;
    // public GameObject Buttons;

    private int currentBalance;
    // Start is called before the first frame update
    void Start()
    {
        currentBalance = 50000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DepositButton()
    {
        selectButtons.SetActive(false);
        depositWindow.SetActive(true);
    }

    public void WithdrawButton()
    {
        selectButtons.SetActive(false);
        withdrawWindow.SetActive(true);
    }
}
