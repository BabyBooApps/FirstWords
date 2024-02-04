using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData instance;

    public List<Word_Obj> Alphabet_List = new List<Word_Obj>();
    public List<Word_Obj> Number_List = new List<Word_Obj>();
    public List<Word_Obj> Color_List = new List<Word_Obj>();
    public List<Word_Obj> Animal_List = new List<Word_Obj>();
    public List<Word_Obj> Fruits_List = new List<Word_Obj>();
    public List<Word_Obj> Vegtable_List = new List<Word_Obj>();
    public List<Word_Obj> Birds_List = new List<Word_Obj>();
    public List<Word_Obj> FarmAnimals_List = new List<Word_Obj>();
    public List<Word_Obj> SeaAnimals_List = new List<Word_Obj>();
    public List<Word_Obj> Shapes_List = new List<Word_Obj>();
    public List<Word_Obj> Sports_List = new List<Word_Obj>();
    public List<Word_Obj> Vehicles_List = new List<Word_Obj>();
    public List<Word_Obj> MusicalInstruments_List = new List<Word_Obj>();
    public List<Word_Obj> BodyParts_List = new List<Word_Obj>();


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
   
}
