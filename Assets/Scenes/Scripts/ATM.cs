using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATM : MonoBehaviour
{
    public GameObject selectButtons;
    public GameObject depositWindow;
    public GameObject withdrawWindow;
    // public GameObject noenWindow;
    public Text moneyText;
    public List<InputField> moneyInputField;

    private int inputValue;
    private int atmMoney = 50000;

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        UpdateATMMoney();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DepositInputMoney() // InputField�� ����� �Ա� 
    {
        string inputText = moneyInputField[0].text;
        if (int.TryParse(inputText, out int result))
        {
            inputValue = result;
        }    

        if (player.playerMoney > 0 && player.playerMoney - inputValue >= 0)
        {
            // ���
            player.SubtractMoney(inputValue);
            atmMoney += inputValue;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }
    public void WithdrawInputMoney() // InputField�� ����� ��� 
    {
        string inputText = moneyInputField[1].text;
        if (int.TryParse(inputText, out int result))
        {
            inputValue = result;
        }

        if (atmMoney > 0 && atmMoney - inputValue >= 0)
        {
            // ���
            player.AddMoney(inputValue);
            atmMoney -= inputValue;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }

    public void Deposit10000()
    {
        if (player.playerMoney > 0 && player.playerMoney - inputValue >= 0)
        {
            // ���
            player.SubtractMoney(10000);
            atmMoney += 10000;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }
    public void Deposit30000()
    {
        if (player.playerMoney > 0 && player.playerMoney - inputValue >= 0)
        {
            // ���
            player.SubtractMoney(30000);
            atmMoney += 30000;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }
    public void Deposit50000()
    {
        if (player.playerMoney > 0 && player.playerMoney - inputValue >= 0)
        {
            // ���
            player.SubtractMoney(50000);
            atmMoney += 50000;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }




    public void Withdraw10000()
    {
        if (atmMoney > 0 && atmMoney - inputValue >= 0)
        {
            // ���
            player.AddMoney(10000);
            atmMoney -= 10000;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }
    public void Withdraw30000()
    {
        if (atmMoney > 0 && atmMoney - inputValue >= 0)
        {
            // ���
            player.AddMoney(30000);
            atmMoney -= 30000;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
    }
    public void Withdraw50000()
    {
        if (atmMoney > 0 && atmMoney - inputValue >= 0)
        {
            // ���
            player.AddMoney(50000);
            atmMoney -= 50000;
            UpdateATMMoney();
        }
        else
        {
            // �ȵ����� â
        }
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

    public void BackButton()
    {
        selectButtons.SetActive(true);
        depositWindow.SetActive(false);
        withdrawWindow.SetActive(false);
    }
    
    private void UpdateATMMoney()
    {
        moneyText.text = atmMoney.ToString();
    }
}
