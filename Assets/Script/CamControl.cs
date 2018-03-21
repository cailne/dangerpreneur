using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl: MonoBehaviour {
    public float speed = 20f;
    public float scrollSpeed = 2f;
    //DEFAULT ORTHOGRAPHIC SIZE
    public float zoomSize = 5;
    public Vector2 camLimit;
    
    void Update(){
        Vector2 pos = transform.position;
        if (Input.GetMouseButton(0))
        {
            pos.x -= Input.GetAxis("Mouse X") * speed* Time.deltaTime;
            pos.y -= Input.GetAxis("Mouse Y") * speed* Time.deltaTime;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0){
            if (zoomSize > 2){
                zoomSize -= 1;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0){
            if (zoomSize < 5){
                zoomSize += 1;
            }
        }

        GetComponent<Camera>().orthographicSize = zoomSize;

        pos.x = Mathf.Clamp(pos.x, -camLimit.x, camLimit.x);
        pos.y = Mathf.Clamp(pos.y, -camLimit.y, camLimit.y);

        transform.position = pos;
    }
}