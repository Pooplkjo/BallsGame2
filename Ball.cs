using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    static int fallen = 0;
    static int clicked = 0;
    [SerializeField]    TextMeshProUGUI fall;
    [SerializeField]    TextMeshProUGUI click;
    [SerializeField] GameObject win;
    [SerializeField] GameObject lose;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        gameObject.SetActive(false);
        clicked++;
        click.text = clicked.ToString();
        if(clicked >= 5){
            Debug.Log("you win");
            win.SetActive(true);
        }
        ;
    }

    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag == "Ground"){
            fallen++;
            gameObject.SetActive(false);
            fall.text = fallen.ToString();
            if(fallen >= 4){
                Debug.Log("You lose");
                lose.SetActive(true);
            }
        }
            
    }
    
}
