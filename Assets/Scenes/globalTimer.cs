using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalTimer : MonoBehaviour
{
    public static float globalTimeMax=3.2f;
    public static void changeTimerMax(float change){
        globalTimeMax-=change;
    }
    public static float getTimerMax(){
        return globalTimeMax;
    }
}
