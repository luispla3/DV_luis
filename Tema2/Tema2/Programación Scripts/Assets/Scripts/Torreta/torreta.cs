using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torreta : MonoBehaviour
{
    public Transform target;
    Transform canyon;
    public GameObject municionPrefab;
    public Transform salida_municion;
    
    // Start is called before the first frame update
    void Start()
    {
        canyon = transform.Find("Elevación");
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position.y es la de la propia torreta
        Vector3 target_proyectado = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(target_proyectado);
        canyon.LookAt(target);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bala = Instantiate(municionPrefab);
            bala.transform.position = canyon.position;
            Municion municion = bala.GetComponent<Municion>();
            municion.Lanzar(salida_municion);
        }    
        
    }
}
