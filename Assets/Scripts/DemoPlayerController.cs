
using UnityEngine;

/// First-person player controller for Resonance Audio demo scenes.

public class DemoPlayerController : MonoBehaviour {
  /// Camera.
  public Camera mainCamera;





  // Target camera rotation in degrees.
  private float rotationX = 0.0f;
  private float rotationY = 0.0f;

  // Maximum allowed vertical rotation angle in degrees.
  private const float clampAngleDegrees = 80.0f;

  // Camera rotation sensitivity.
  private const float sensitivity = 2.0f;

  void Start() {
   
    Vector3 rotation = mainCamera.transform.localRotation.eulerAngles;
    rotationX = rotation.x;
    rotationY = rotation.y;
  }

  void LateUpdate() {
#if UNITY_EDITOR
    //if (Input.GetMouseButtonDown(0)) {
    //  SetCursorLock(true);
    //} else if (Input.GetKeyDown(KeyCode.Escape)) {
    //  SetCursorLock(false);
    //}
#endif  // UNITY_EDITOR
    // Update the rotation.
    float mouseX = Input.GetAxis("Mouse X");
    float mouseY = -Input.GetAxis("Mouse Y");
    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
      // Note that multi-touch control is not supported on mobile devices.
      mouseX = 0.0f;
      mouseY = 0.0f;
    }
    rotationX += sensitivity * mouseY;
    rotationY += sensitivity * mouseX;
    rotationX = Mathf.Clamp(rotationX, -clampAngleDegrees, clampAngleDegrees);
    mainCamera.transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
    // Update the position.
  
  }

  // Sets the cursor lock for first-person control.
  private void SetCursorLock(bool lockCursor) {
    if (lockCursor) {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    } else {
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    }
  }
}
