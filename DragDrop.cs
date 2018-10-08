using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour {
    Vector3 iniPos;
    bool isChild;
    float t;
    // Use this for initialization
    void Start() {
        iniPos = transform.position;
        isChild = false;
        t = 0;

    }

    // Update is called once per frame
    void Update() {
        if (isChild) {
            MovementControler.instance.enabled = false;
            SnappedRotation.instance.enabled = false;
            if (Input.GetAxis("Horizontal") != 0) {
                transform.Rotate(0, 10f * Input.GetAxis("Horizontal"), 0);
            } else if (Input.GetAxis("Vertical") != 0) {
                t = Vector3.Distance(Camera.main.transform.position, transform.position);
                print(t);
                if (t > 5 && t < 20) {

                    transform.localPosition = transform.localPosition + new Vector3(0, 0, 5f * Input.GetAxis("Vertical") * Time.deltaTime);
                }
                //				else 
                //					transform.localPosition = transform.localPosition +new Vector3 (0, 0, 5f * Input.GetAxis ("Vertical") * Time.deltaTime);}}
                	}
            }
        }

        public void OnGazeDown()

        {
            transform.SetParent(Camera.main.transform);
            isChild = true;
        }

        public void OnGazeUp()

        {
            transform.SetParent(null);
            transform.position = iniPos;
            transform.rotation = Quaternion.identity;
            isChild = false;
        }


    } 
