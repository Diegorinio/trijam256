using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicManager : MonoBehaviour
{
    private static musicManager musicInstance;
    void Awake(){
        DontDestroyOnLoad(gameObject);
        if(musicInstance==null){
            musicInstance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
}
