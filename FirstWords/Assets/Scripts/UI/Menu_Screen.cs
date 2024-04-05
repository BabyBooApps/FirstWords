using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Screen : MonoBehaviour
{

    public Button NoAdsBtn;
    public void On_Alphabets_Btn_Click()
    {
        UI_Manager.instance.On_Alphabets_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Numbers_Btn_Click()
    {
        UI_Manager.instance.On_Numbers_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Colors_Btn_Click()
    {
        UI_Manager.instance.On_Colors_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Animals_Btn_Click()
    {
        UI_Manager.instance.On_Animals_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_FarmAnimals_Btn_Click()
    {
        UI_Manager.instance.On_FarmAnimals_Btn_Click();
        this.gameObject.SetActive(false);
    }
    public void On_SeaAnimals_Btn_Click()
    {
        UI_Manager.instance.On_SeaAnimals_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Birds_Btn_Click()
    {
        UI_Manager.instance.On_Birds_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Fruits_Btn_Click()
    {
        UI_Manager.instance.On_Fruits_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Vegtables_Btn_Click()
    {
        UI_Manager.instance.On_Vegtables_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Shapes_Btn_Click()
    {
        UI_Manager.instance.On_Shapes_Btn_Click();
        this.gameObject.SetActive(false);
    }


    public void On_Home_Button_Click()
    {
        UI_Manager.instance.On_Home_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void On_Sports_Button_Click()
    {
        UI_Manager.instance.On_Sports_Btn_Click();
        this.gameObject.SetActive(false);
    }
    public void On_Vehicles_Button_Click()
    {
        UI_Manager.instance.On_Vehicles_Btn_Click();
        this.gameObject.SetActive(false);
    }
    public void On_MusicalInstruments_Button_Click()
    {
        UI_Manager.instance.On_Musical_Instruments_Btn_Click();
        this.gameObject.SetActive(false);
    }
    public void On_BodyParts_Button_Click()
    {
        UI_Manager.instance.On_BodyParts_Btn_Click();
        this.gameObject.SetActive(false);
    }

    public void Set_No_Ads_Btn()
    {
        //NoAdsBtn.enabled = !PlayerPrefsManager.Instance.GetNoAdsStatus();
        NoAdsBtn.gameObject.SetActive(!PlayerPrefsManager.Instance.GetNoAdsStatus());
    }
}
