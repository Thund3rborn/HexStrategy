using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class HexGrid : MonoBehaviour
{
    private Mesh m_mesh;
    private MeshFilter m_meshFilter;
    private MeshRenderer m_meshRenderer;

    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        m_meshFilter = GetComponent<MeshFilter>();
        m_meshRenderer= GetComponent<MeshRenderer>();

        m_mesh = new Mesh();
        m_mesh.name = "Hex";

        m_meshFilter.mesh = m_mesh;
        m_meshRenderer.material= material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
