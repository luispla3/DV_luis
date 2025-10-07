using UnityEngine;
using System.Collections;

public class SemaforoAnimator : MonoBehaviour {

	public Material rojo;
	public Material ambar;
	public Material verde;
	public Material rojoPeaton;
	public Material verdePeaton;
    public float duracionRojo;
	public float duracionAmbar;
	public float duracionVerde;
	public float duracionParpadeo;
    public Animator animator;
	// Use this for initialization
	void Start ()
    {
	    BuscaMateriales ();
        animator = gameObject.GetComponent<Animator>();
    }
    public void VerdePeaton(float v)
    {
        verdePeaton.SetColor("_EmissionColor", Color.white*v);
    }

    void CambioEstado()
    {
        animator.SetTrigger("cambioEstado");
    }

    void BuscaMateriales()
	{
		foreach (MeshRenderer mr in GetComponentsInChildren<MeshRenderer>())
			foreach (Material m in mr.materials) {
				if (m.name.StartsWith (rojo.name))
					rojo = m;
				else if (m.name.StartsWith (ambar.name))
					ambar = m;
				else if (m.name.StartsWith (verde.name))
					verde = m;
				else if (m.name.StartsWith (rojoPeaton.name))
					rojoPeaton = m;
				else if (m.name.StartsWith (verdePeaton.name))
					verdePeaton = m;
			}
	}	
}
