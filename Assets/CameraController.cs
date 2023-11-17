
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float scrollSpeed = 5f;
    private bool doMovement = true;
    public float panBorederThickness = 10f;
    public float panSpeed = 30f;
    public float maxY = 82f;
    public float minY = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            doMovement = !doMovement;
        if (!doMovement)
            return;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorederThickness)
        {
            transform.Translate(-Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= panBorederThickness)
        {
            transform.Translate(-Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorederThickness)
        {
            transform.Translate(-Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorederThickness)
        {
            transform.Translate(-Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        

        Vector3 pos = transform.position;

        pos.y -= scroll * 2000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);   
        transform.position = pos;
    }
}
