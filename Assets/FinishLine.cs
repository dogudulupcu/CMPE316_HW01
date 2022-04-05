using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    public AudioSource src;
    private void OnTriggerEnter(Collider other){
        
         
             GameObject.Find("Player").SendMessage("Finish");
             
            src.Stop();
        // if(other.gameObject.name == "Player"){
        //     Debug.Log("Player has reached the finish line");
       //  }
    }
    
}
