using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelStartup : MonoBehaviour
{
    float waitTimer=3;
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitTimer-=Time.deltaTime;
        timeText.text = int.Parse(waitTimer.ToString()).ToString();
        if(waitTimer<=0){
            Destroy(gameObject);
        }
    }
}
