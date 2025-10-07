using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialcambia : StateMachineBehaviour {
    //public GameObject kk;   
	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        SemaforoAnimator sem = animator.GetComponent<SemaforoAnimator>();

        if (stateInfo.IsTag("rojo"))
        {
            Debug.Log("Disco rojo - peaton verde");
            sem.rojo.SetColor("_EmissionColor", Color.red);
            sem.verdePeaton.SetColor("_EmissionColor", Color.green);
            sem.Invoke("CambioEstado", sem.duracionRojo);
        }
        else if (stateInfo.IsTag("parpadeo"))
        {
            Debug.Log("Disco rojo - peaton parpadea");
            sem.rojo.SetColor("_EmissionColor", Color.red);
            sem.Invoke("CambioEstado", 4);
            sem.Invoke("CambioEstado", sem.duracionParpadeo);
        }
        else if (stateInfo.IsTag("ambar"))
        {
            Debug.Log("Disco ambar - peaton rojo");
            sem.ambar.SetColor("_EmissionColor", Color.yellow);
            sem.rojoPeaton.SetColor("_EmissionColor", Color.red);
            sem.Invoke("CambioEstado", sem.duracionAmbar);
        }
        else if (stateInfo.IsTag("verde"))
        {
            Debug.Log("Disco verde - peaton rojo");
            sem.verde.SetColor("_EmissionColor", Color.green);
            sem.rojoPeaton.SetColor("_EmissionColor", Color.red);
            sem.Invoke("CambioEstado", sem.duracionVerde);
        }
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

        SemaforoAnimator sem = animator.GetComponent<SemaforoAnimator>();
        Debug.Log("Salgo del estado");
        sem.rojo.SetColor("_EmissionColor", Color.black);
        sem.ambar.SetColor("_EmissionColor", Color.black);
        sem.verde.SetColor("_EmissionColor", Color.black);
        sem.verdePeaton.SetColor("_EmissionColor", Color.black);
        sem.rojoPeaton.SetColor("_EmissionColor", Color.black);
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
