using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour
{
    //Clicker 
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    //Shop
    public int shop1price;
    public Text shop1text;

    public int shop2price;
    public Text shop2text;

    public int shop3price;
    public Text shop3text;

    public int shop4price;
    public Text shop4text;
    //Amount
    public Text amount1Text;
    public int amount1;
    public float amount1Profit;

    public Text amount2Text;
    public int amount2;
    public float amount2Profit;

    public Text hitPowerText;

    public Text amount3Text;
    public int amount3;
    public float amount3Profit;

    public Text amount4Text;
    public int amount4;
    public float amount4Profit;
    //Upgrade
    public int upgradePrice;
    public Text upgradeText;

    //New
    public int allUpgradePrice;
    public Text allUpgradeText;

    //Statusbox
    public Text statusBox;


    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;

        //we must set all default variables before load
        shop1price = 25;
        shop2price = 125;
        shop3price = 225;
        shop4price = 525;
        amount1 = 0;
        amount1Profit = 1;
        amount2 = 0;
        amount2Profit = 5;
        amount3 = 0;
        amount3Profit = 25;
        amount4 = 0;
        amount4Profit = 100;


        //reset line
        //PlayerPrefs.DeleteAll();

        //load
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        hitPower = PlayerPrefs.GetInt("hitPower", 1);
        x = PlayerPrefs.GetInt("x",0);

        shop1price = PlayerPrefs.GetInt("shop1price", 25);
        shop2price = PlayerPrefs.GetInt("shop2price", 125);
        shop3price = PlayerPrefs.GetInt("shop3price", 225);
        shop4price = PlayerPrefs.GetInt("shop4price", 525);
        amount1 = PlayerPrefs.GetInt("amount1", 0);
        amount1Profit = PlayerPrefs.GetInt("amount1Profit", 0);
        amount2 = PlayerPrefs.GetInt("amount2", 0);        
        amount2Profit = PlayerPrefs.GetInt("amount2Profit", 0);
        amount3 = PlayerPrefs.GetInt("amount3", 0);
        amount3Profit = PlayerPrefs.GetInt("amount3Profit", 0);
        amount4 = PlayerPrefs.GetInt("amount4", 0);
        amount4Profit = PlayerPrefs.GetInt("amount4Profit", 0);
        upgradePrice = PlayerPrefs.GetInt("upgradePrice", 50);

        //new
        allUpgradePrice = 900;




    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)currentScore + " $";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;


        //Shop
        shop1text.text = "Tier 1: " + shop1price + " $";
        shop2text.text = "Tier 2: " + shop2price + " $";
        shop3text.text = "Tier 3: " + shop3price + " $";
        shop4text.text = "Tier 4: " + shop4price + " $";

        //Amount
        hitPowerText.text = "Hit Power : " + hitPower + " /click";
        amount1Text.text = "Tier 1: "+amount1+" arts $: "+amount1Profit+"/s";
        amount2Text.text = "Tier 2: "+amount2+" arts $: "+amount2Profit+"/s";
        amount3Text.text = "Tier 3: " + amount3 + " arts $: " + amount3Profit + "/s";
        amount4Text.text = "Tier 4: " + amount4 + " arts $: " + amount4Profit + "/s";
        //Upgrade
        upgradeText.text = "Cost: " + upgradePrice + " $";

        //Save
        PlayerPrefs.SetInt("currentScore", (int)currentScore);
        PlayerPrefs.SetInt("hitPower", (int)hitPower);
        PlayerPrefs.SetInt("x", (int)x);
        PlayerPrefs.SetInt("shop1price", (int)shop1price);
        PlayerPrefs.SetInt("shop2price", (int)shop2price);
        PlayerPrefs.SetInt("shop3price", (int)shop3price);
        PlayerPrefs.SetInt("shop4price", (int)shop4price);
        PlayerPrefs.SetInt("amount1", (int)amount1);
        PlayerPrefs.SetInt("amount1Profit", (int)amount1Profit);
        PlayerPrefs.SetInt("amount2", (int)amount2);
        PlayerPrefs.SetInt("amount2Profit", (int)amount2Profit);
        PlayerPrefs.SetInt("amount3", (int)amount3);
        PlayerPrefs.SetInt("amount3Profit", (int)amount3Profit);
        PlayerPrefs.SetInt("amount4", (int)amount4);
        PlayerPrefs.SetInt("amount4Profit", (int)amount4Profit);
        PlayerPrefs.SetInt("upgradePrice", (int)upgradePrice);
        //new
        allUpgradeText.text = "Cost: " + allUpgradePrice + " $";
    }

    //Hit
    public void Hit()
    {
        currentScore += hitPower;
    }
    //Shop
    public void Shop1()
    {
        if (currentScore >= shop1price)
        {
            currentScore -= shop1price;
            amount1 += 1;
            amount1Profit += 1;
            x += 1;
            shop1price += 25;
        }
        else
        {
            statusBox.text= "Not enought money ";
            statusBox.GetComponent<Animation>().Play("status");
        }
    }
    public void Shop2()
    {
        if (currentScore >= shop2price)
        {
            currentScore -= shop2price;
            amount2 += 1;
            amount2Profit += 5;
            x += 5;
            shop2price += 125;
        }
        else
        {
            statusBox.text = "Not enought money ";
            statusBox.GetComponent<Animation>().Play("status");
        }
    }
    public void Shop3()
    {
        if (currentScore >= shop3price)
        {
            currentScore -= shop3price;
            amount3 += 1;
            amount3Profit += 25;
            x += 25;
            shop3price += 225;
        }
        else
        {
            statusBox.text = "Not enought money ";
            statusBox.GetComponent<Animation>().Play("status");
        }
    }
    public void Shop4()
    {
        if (currentScore >= shop4price)
        {
            currentScore -= shop4price;
            amount4 += 1;
            amount4Profit += 100;
            x += 100;
            shop4price += 525;
        }
        else
        {
            statusBox.text = "Not enought money ";
            statusBox.GetComponent<Animation>().Play("status");
        }
    }
    //Upgrade
    public void Upgrade()
    {
        if (currentScore>=upgradePrice)
        {
            currentScore -= upgradePrice;
            hitPower *= 2;
            upgradePrice *= 3;
        }
        else
        {
            statusBox.text = "Not enought money ";
            statusBox.GetComponent<Animation>().Play("status");
        }
    }
    //new
    public void AllProfitsUpgrade()
    {
        if (currentScore>=allUpgradePrice)
        {
            currentScore -= allUpgradePrice;
            x *= 2;
            allUpgradePrice *= 3;
            amount1Profit *= 2;
            amount2Profit *= 2;
            amount3Profit *= 2;
            amount4Profit *= 2;
        }
        else
        {
            statusBox.text = "Not enought money ";
            statusBox.GetComponent<Animation>().Play("status");
        }
    }
}
