using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartTime : MonoBehaviour
{
    private bool check=true;
    private void OnTriggerEnter(Collider other){
        
         if(check == true){
             GameObject.Find("Player").SendMessage("TimeStart");
             check=false;
    }
            
        // if(other.gameObject.name == "Player"){
        //     Debug.Log("Player has reached the finish line");
       //  }
    }
    
}
