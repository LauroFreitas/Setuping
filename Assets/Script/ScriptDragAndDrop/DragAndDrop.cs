using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public float a;
    public float y;
    public GameObject objectHit;
    public GameObject obj;
    public static  bool ativo = true;

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
                        objectHit = hit.transform.gameObject;
                        Debug.DrawLine(ray.origin, hit.point);
                        ativo = false;
                    }

                    if(objectHit != null)
                    {
                        obj.transform.position = new Vector3(hit.point.x, y, hit.point.z);
                        objectHit.transform.position = obj.transform.position;
                        Debug.Log(obj.transform.position);
                    }
                }
            }
           
        }
        else
        {
            objectHit = null;
            ativo = true;
        }
            
    }
}