using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kabelki : MonoBehaviour
{
    public enum Kolorki {red,green,blue};
    public Kolorki kolorek;
    bombabehaviour bomba;
    public GameObject referencja;
    // Start is called before the first frame update
    void Start()
    {
        bomba = referencja.GetComponent<bombabehaviour>();
        Image img = gameObject.GetComponent<Image>();
        switch (kolorek){
            case Kolorki.red:
            img.color = Color.red;
            break;
            case Kolorki.green:
            img.color = Color.green;
            break;
            case Kolorki.blue:
            img.color = Color.blue;
            break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        // bombabehaviour.wybrany_kabelek = gameObject;
        bomba.SetKabelek(gameObject);
    }
}
