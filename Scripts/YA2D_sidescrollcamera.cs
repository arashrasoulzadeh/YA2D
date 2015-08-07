using UnityEngine;
using System.Collections;

public class YA2D_sidescrollcamera : MonoBehaviour {
    public GameObject Target;
    public float left,right,mainfov,zoomfov;
 
    void LateUpdate()
    {
       
            if (Target.transform.position.x > left && Target.transform.position.x < right )
            {
                    if (transform.GetComponent<Camera>().fieldOfView < mainfov)
                        transform.GetComponent<Camera>().fieldOfView += 1f  * Time.deltaTime;
                    
                    Vector3 position = Target.transform.position;
                    position.z = -4f;
                    position.y = transform.position.y;
                
                    transform.position =position;
                }else{
                    //  transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
                    if (transform.GetComponent<Camera>().fieldOfView > zoomfov)
                    transform.GetComponent<Camera>().fieldOfView -= 1f  * Time.deltaTime;
                    
               
    
            }
    
    }
}