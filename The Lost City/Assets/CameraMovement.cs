using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float speed = 0.1f;
    float zoomSpeed = 10.0f;
    float rotationSpeed = 0.1f;

    float maxHgh = 75f;
    float minHgh = 30f;
    

    Vector2 p1;
    Vector2 p2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftShift)) {
            speed = 0.1f;
            zoomSpeed = 20f;
        }
        else
        {
            speed = 0.05f;
            zoomSpeed = 10f;
        }
        float hsp = speed * Input.GetAxis("Horizontal");
        float vsp = speed * Input.GetAxis("Vertical");
        float scrollsp = Mathf.Log(transform.position.y) * -zoomSpeed * Input.GetAxis("Mouse ScrollWheel");

        if ((transform.position.y >= maxHgh) && (scrollsp > 0))
        {
            scrollsp = 0;
        }
        else if ((transform.position.y <= minHgh) && (scrollsp < 0))
        {
            scrollsp = 0;
        } 
        

        if ((transform.position.y + scrollsp) > maxHgh) { 
            scrollsp = maxHgh - transform.position.y;
        }
        else if ((transform.position.y + scrollsp) < minHgh)
        {
            scrollsp = minHgh - transform.position.y;
        }

        Vector3 vericalMove = new Vector3 (0, scrollsp, 0);
        Vector3 lateralMove = hsp * transform.right;
        Vector3 forwardMove = transform.forward;
        forwardMove.y = 0;
        forwardMove.Normalize();
        forwardMove *= vsp;

        Vector3 move = vericalMove + lateralMove + forwardMove;

        transform.position += move;

        getCameraRotation();

    }


    void getCameraRotation()
    {
        if (Input.GetMouseButtonDown(2))
        {
            p1 = Input.mousePosition;
        }

        if(Input.GetMouseButton(2))
        {
            p2 = Input.mousePosition;

            float dx = (p2 - p1).x * rotationSpeed;
            float dy = (p2 - p1).y * rotationSpeed;

            transform.rotation *= Quaternion.Euler(new Vector3(0, dx, 0));
            transform.GetChild(0).transform.rotation *= Quaternion.Euler(new Vector3(-dy, 0, 0));

            p1 = p2;
        }
    
    }


}
