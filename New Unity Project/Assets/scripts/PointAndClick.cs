using UnityEngine;
using UnityEngine.Events;

public class PointAndClick : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray click = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(click, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }

        void PrintName(GameObject go)
        {
            print(go.name);

        }


    }
}
