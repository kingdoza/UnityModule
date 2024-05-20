using UnityEngine;
using UnityEngine.Events;

public class ClickPositioning : MonoBehaviour {
    void Update() {
        if(Input.GetMouseButtonDown(1)) {
            Vector3 clickPoint = GetMouseWorldPosition();
        }
    }

    private Vector3 GetMouseWorldPosition() {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}