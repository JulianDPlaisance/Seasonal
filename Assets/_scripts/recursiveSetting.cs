using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recursiveSetting : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("deactivate"))
        {
            for (int k = 0; k < other.transform.childCount; k++)
            {
                other.transform.GetChild(k).gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("deactivate"))
        {
            for (int k = 0; k < other.transform.childCount; k++)
            {
                other.transform.GetChild(k).gameObject.SetActive(false);
            }
        }
    }
}
