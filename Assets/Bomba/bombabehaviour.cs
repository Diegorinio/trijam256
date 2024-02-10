using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bombabehaviour : MonoBehaviour
{
    public Image hintImg;
    float timer;
    public static GameObject wybrany_kabelek;
    public List<GameObject> kabelki_lista;
    public static GameObject chciany_kabelek;
    public Slider timer_slider;
    public GameObject gameOverPanel;
    public GameObject gameWinPanel;
    // Start is called before the first frame update
    private void Awake() {
        // float refTime = globalTimer.globalTimeMax;
        timer= globalTimer.getTimerMax();    
    }
    void Start()
    {
        timer_slider.value = timer;
        chciany_kabelek = kabelki_lista[Random.Range(0,kabelki_lista.Count)];
        hintImg.color = chciany_kabelek.GetComponent<kabelki>().getColor();
        Debug.Log($"Chciany kabelek {chciany_kabelek.name} {hintImg.color}");
    }
    //
    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        timer_slider.value = timer;
        if(timer <=0){
            // Time.timeScale=0.0f;
            gameOverPanel.SetActive(true);
        }
    }

    public void SetKabelek(GameObject obj){
        if(obj==chciany_kabelek){
            Debug.Log($"chuuuj");
            gameWinPanel.SetActive(true);
        }
        else{
            Debug.Log("Przejebales");
            gameOverPanel.SetActive(true);
        }
    }

}
