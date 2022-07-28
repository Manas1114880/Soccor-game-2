
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{

   public float sensitivity = 100f;
   public Transform playerBody;
   float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
    float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

    //xRotation -= mouseY;
    xRotation = Mathf.Clamp(xRotation, -180f, 180f);

    this.transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);
    this.playerBody.Rotate(Vector3.up * mouseX);

    }
}
