using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{

    public GameObject arrow;
    public float LunchForce;
    public Transform shootPoint;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("[Script Started Running...]");
    }

    // Update is called once per frame
    void Update()
    {

        /**
        * this code with move cube with mouse cursor position
        **/
        // cube initial position
        Vector2 bowPosition = transform.position;
        // getting mouse x, y and z coordinates and storig in mousePosition vector3 veriable
        Vector3 mousePosition = Input.mousePosition;
        // setting mouse z coordinate to 10
        mousePosition.z = 10;
        Vector2 mouse = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = mouse - bowPosition;
        transform.right = direction;

        // Debug.Log("Bow: " + bowPosition);
        // Debug.Log("Mouse: " + mousePosition);
        // Debug.Log("Direction: " + direction);
        // Debug.Log("Transform: " + transform.right);
        // Debug.Log("inputMouse: " + Input.mousePosition);

        // when clicked mouse botton
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot(){
        // instantiating arrow in game scene
        GameObject newArrow = Instantiate(arrow, shootPoint.position, shootPoint.rotation);
        newArrow.GetComponent<Rigidbody>().velocity = transform.right * LunchForce; 
    }
}
