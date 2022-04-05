using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
  public float speed;
    void Update()
    {
        Lookatmouse();
    }

    void Lookatmouse(){
        Plane playerplane = new Plane(Vector3.up,transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist;
        
        if(playerplane.Raycast(ray,out hitdist))
        {
            Vector3 targetPoint = ray.GetPoint(hitdist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,speed*Time.deltaTime);
        }
    }
}
