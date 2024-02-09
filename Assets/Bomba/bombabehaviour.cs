using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bombabehaviour : MonoBehaviour
{
    public Image hintImg;
    float timer=3.2f;
    Color[] colors = new Color[] {Color.red,Color.blue,Color.green};
    public static GameObject wybrany_kabelek;
    public List<GameObject> kabelki_lista;
    public static GameObject chciany_kabelek;
    public Slider timer_slider;
    public GameObject gameOverPanel;
    public GameObject gameWinPanel;
    bool isOver=false;
    // Start is called before the first frame update
    void Start()
    {
        timer_slider.value = timer;
        // _sprite.Sprite.color = colors[Random.Range(0, color.Length-1)];
        // hintImg.color = colors[Random.Range(0,colors.Length-1)];
        chciany_kabelek = kabelki_lista[Random.Range(0,kabelki_lista.Count)];
        hintImg.color = chciany_kabelek.GetComponent<Image>().color;
    }
    //
    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        timer_slider.value = timer;
        if(timer <=0){
            // Time.timeScale=0.0f;
            gameOverPanel.SetActive(false);
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
