using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SellWeapon : MonoBehaviour {

    public Text ShowMulti1, ShowMulti2, ShowMulti3;
    public Text refreshingTime;
    float multi1, multi2, multi3, mmaster;
    float timeRefresh;

	// Use this for initialization
	void Start () {
        timeRefresh = 20;
        RandomMultiplier();
        SetMulti1();
        RandomMultiplier();
        SetMulti2();
        RandomMultiplier();
        SetMulti3();
        PlayerPrefs.SetFloat("ShopMM", 0f);
	}
	
	// Update is called once per frame
	void Update () {
        timeRefresh -= Time.deltaTime;
	}

    void RandomMultiplier()
    {
        int yue = UnityEngine.Random.Range(1, 5);
        switch (yue)
        {
            case 1:
                mmaster = 0.5f;
                //not needed tho
                break;
            case 2:
                mmaster = 1f;
                //a little too much, but still kinda needed
                break;
            case 3:
                mmaster = 1.25f;
                //needed
                break;
            case 4:
                mmaster = 1.5f;
                //urgently needed
                break;
            case 5:
                mmaster = 2f;
                //rare
                break;
        }
    }

    void SetMulti1()
    {
        RandomMultiplier();
        PlayerPrefs.SetFloat("ShopMulti1", mmaster);
        ShowMulti1.text = "" + PlayerPrefs.GetFloat("ShopMulti1").ToString();
    }

    void SetMulti2()
    {
        RandomMultiplier();
        PlayerPrefs.SetFloat("ShopMulti2", mmaster);
        ShowMulti2.text = "" + PlayerPrefs.GetFloat("ShopMulti2").ToString();
    }

    void SetMulti3()
    {
        RandomMultiplier();
        PlayerPrefs.SetFloat("ShopMulti3", mmaster);
        ShowMulti3.text = "" + PlayerPrefs.GetFloat("ShopMulti3").ToString();
    }

    public void OnPressShop1(){
        PlayerPrefs.SetFloat("ShopMM", PlayerPrefs.GetFloat("ShopMulti1"));
        SceneManager.LoadScene("Selling");
    }
    public void OnPressShop2(){
        PlayerPrefs.SetFloat("ShopMM", PlayerPrefs.GetFloat("ShopMulti2"));
        SceneManager.LoadScene("Selling");
    }
    public void OnPressShop3(){
        PlayerPrefs.SetFloat("ShopMM", PlayerPrefs.GetFloat("ShopMulti3"));
        SceneManager.LoadScene("Selling");
    }

    private void OnGUI()
    {
        if (timeRefresh > 0)
        {
            refreshingTime.text = "Demands change in: " + (int)timeRefresh + " sec";
        }
        else
        {
            Start();
        }
    }

    IEnumerator RandomNow(){
        RandomMultiplier();
        SetMulti1();
        yield return new WaitForSeconds(0.1f);
        RandomMultiplier();
        SetMulti2();
        yield return new WaitForSeconds(0.1f);
        RandomMultiplier();
        SetMulti3();
    }
}
