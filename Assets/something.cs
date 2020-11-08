using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class something: MonoBehaviour
{
     //Declare RectTransform in script
     public RectTransform fistPic;
     //The new position of your button
     Vector3 newPos = new Vector3(-42, 0, 0);
     //Reference value used for the Smoothdamp method
     private Vector3 buttonVelocity = Vector3.zero;
     //Smooth time
     private float smoothTime = 0.5f;
 
     void Start()
     {
         //Get the RectTransform component
         fistPic = GetComponent<RectTransform>();
     }
    
     void Update()
     {
         //Update the localPosition towards the newPos
         fistPic.localPosition = Vector3.SmoothDamp(fistPic.localPosition, newPos, ref buttonVelocity, smoothTime);
     }

}
