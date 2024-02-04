using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vegtable_Scene : MonoBehaviour
{
    public Button NextBtn;
    public Button PreviousBtn;
    public Button HomeBtn;

    public void Set_NextBtn(bool isActive)
    {
        NextBtn.gameObject.SetActive(isActive);
    }

    public void Set_PrevBtn(bool isActive)
    {
        PreviousBtn.gameObject.SetActive(isActive);
    }

    public void On_Home_Btn_Pressed()
    {
        UI_Manager.instance.On_Menu_Btn_Pressed();
        GamePlayManager.instance.DeactivateCurrentLevel();
        this.gameObject.SetActive(false);
    }
}
