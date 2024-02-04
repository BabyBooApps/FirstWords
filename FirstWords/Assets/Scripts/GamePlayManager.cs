using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager instance;

    public List<Alphabets_Scene> LearningScenes = new List<Alphabets_Scene>();
    public int LevelId = -1;

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

    public void Activate_Level(int id)
    {
        DeactivateCurrentLevel();
        LevelId = id;
        LearningScenes[LevelId-1].gameObject.SetActive(true);
        LearningScenes[LevelId-1].StartLevel();
    }

    public void DeactivateCurrentLevel()
    {
        if(LevelId >= 0)
        {
            LearningScenes[LevelId-1].gameObject.SetActive(false);
        }
       
    }
}
