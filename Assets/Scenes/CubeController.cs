using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
  private Transform m_transform;
  public float m_moveScale;
    // Start is called before the first frame update
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.A)){
        m_transform.position -= m_moveScale * Vector3.right;
      }
      
      if(Input.GetKey(KeyCode.D)){
        m_transform.position += m_moveScale * Vector3.right;
      }
    }
}
