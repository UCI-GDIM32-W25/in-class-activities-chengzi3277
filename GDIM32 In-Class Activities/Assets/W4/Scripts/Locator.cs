using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour{
    public static Locator Instance { get; private set; }
    public W4Pigeon Player { get; private set; }
    private void Awake(){
        if (Instance != null && Instance != this){
            Destroy(this.gameObject);
            return;
        }
        Instance = this;


    GameObject PlayerObj = GameObject.Find("Player");

   
    Player = PlayerObj.GetComponent<W4Pigeon>();



    }

   
    
}
