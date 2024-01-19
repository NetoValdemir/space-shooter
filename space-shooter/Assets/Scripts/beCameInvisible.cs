using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class beCameInvisible : MonoBehaviour
{

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
