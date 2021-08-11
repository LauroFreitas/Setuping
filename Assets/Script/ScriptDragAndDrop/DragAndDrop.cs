using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public float a;
    public GameObject objectHit;
    public GameObject obj;
    bool ativo = true;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                        
                    if (hit.transform.gameObject.GetComponent<ObjectInteraction>() == true && ativo == true)
                    {
                    Debug.Log("SDASD");

                    objectHit = hit.transform.gameObject;
                    // Debug.Log(hit.point);
                    Debug.DrawLine(ray.origin, hit.point);
                    ativo = false;
                    }

                    obj.transform.position = new Vector3(hit.point.x, 0, hit.point.z);
                    objectHit.transform.position = obj.transform.position;
                    Debug.Log(obj.transform.position);
                }
            }
           
        }
        else
        {
           // ativo = true;
        }
            
    }
}