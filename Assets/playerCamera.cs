using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAmOVE : MonoBehaviour
{
  public float sensX;
  public float sensY;
  public Transform orientation;
  float xRoation;
  float yRoation;
  // Start is called before the first frame update
  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
  }

  // Update is called once per frame
  void Update()
  {
    float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
    float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
    yRoation += mouseX;
    xRoation -= mouseY;
    xRoation = Mathf.Clamp(xRoation, -90f, 90f);

    transform.rotation = Quaternion.Euler(xRoation, yRoation, 0);
    orientation.rotation = Quaternion.Euler(0, yRoation, 0);
  }
}
