using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData instance;

    public List<Word_Obj> Alphabet_List = new List<Word_Obj>();


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
