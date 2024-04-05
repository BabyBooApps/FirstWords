using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home_Screen : MonoBehaviour
{

    public Button NoAdsBtn;
    public void On_Play_Btn_Click()
    {
        UI_Manager.instance.On_Menu_Btn_Pressed();
        this.gameObject.SetActive(false);
    }

    public void OnSettings_Btn_Click()
    {
        UI_Manager.instance.OnSettings_Button_Click();
    }

    public void Set_No_Ads_Btn()
    {
        //NoAdsBtn.enabled = !PlayerPrefsManager.Instance.GetNoAdsStatus();
        NoAdsBtn.gameObject.SetActive(!PlayerPrefsManager.Instance.GetNoAdsStatus());
    }
}
