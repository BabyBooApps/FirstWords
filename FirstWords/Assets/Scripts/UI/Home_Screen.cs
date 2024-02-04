using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Home_Screen : MonoBehaviour
{
  

    public void On_Play_Btn_Click()
    {
        UI_Manager.instance.On_Menu_Btn_Pressed();
        this.gameObject.SetActive(false);
    }

    public void OnSettings_Btn_Click()
    {
        UI_Manager.instance.OnSettings_Button_Click();
    }
}
