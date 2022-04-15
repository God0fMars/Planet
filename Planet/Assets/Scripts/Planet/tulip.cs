using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tulip : MonoBehaviour
{
    MeshRenderer meshRenderer;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material.color = new Color(0, 1, 1);
        Debug.Log("touch");
    }
}
