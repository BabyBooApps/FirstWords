using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;

    public Alphabet_Screen alphabet_Screen;
    public Number_Screen number_Screen;
    public Color_Screen color_Screen;
    public Animal_Screen animal_Screen;
    public Fruits_Screen fruit_Screen;
    public Vegtable_Scene vegtable_Screen;
    public Birds_Screen birds_Screen;
    public FarmAnimals_Screen farmAnimals_Screen;
    public SeaAnimals_Screen seaAnimals_Screen;
    public Shapes_Screen shapes_Screen;
    public Sports_Screen sports_Screen;
    public Vehicles_Screen vehicles_Screen;
    public MusicalInstruments_Screen musicalInstruments_Screen;
    public BodyParts_Screen bodyParts_Screen;
    public SettingsScreen settings_Screen;


    public Menu_Screen menu_Screen;

    public Home_Screen home_Screen;

    private void Awake()
    {
        // Ensure there is only one instance of this class
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void On_Home_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        home_Screen.gameObject.SetActive(true);
    }

    public void On_Menu_Btn_Pressed()
    {
        AudioManager.instance.Play_Btn_Click();
        menu_Screen.gameObject.SetActive(true);
    }

    public void On_Alphabets_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        alphabet_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(1);
    }
    public void On_Numbers_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        number_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(2);
    }
    public void On_Colors_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        color_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(3);
    }
    public void On_Animals_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        animal_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(4);
    }

    public void On_FarmAnimals_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        farmAnimals_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(8);
    }
    public void On_SeaAnimals_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        seaAnimals_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(9);
    }
    public void On_Birds_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        birds_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(7);
    }
    public void On_Fruits_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        fruit_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(5);
    }

    public void On_Vegtables_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        vegtable_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(6);
    }

    public void On_Shapes_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        shapes_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(10);
    }

    public void On_Sports_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        sports_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(11);
    }
    public void On_Vehicles_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        vehicles_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(12);
    }
    public void On_Musical_Instruments_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        musicalInstruments_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(13);
    }
    public void On_BodyParts_Btn_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        bodyParts_Screen.gameObject.SetActive(true);
        GamePlayManager.instance.Activate_Level(14);
    }

    public void OnSettings_Button_Click()
    {
        AudioManager.instance.Play_Btn_Click();
        settings_Screen.gameObject.SetActive(true);
    }

}
