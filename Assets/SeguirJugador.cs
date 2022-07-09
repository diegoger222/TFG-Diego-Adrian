using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : StateMachineBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float distanciaAtaque;

    private Transform player;
    private ArbolCont arbol;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    
        player = GameObject.FindGameObjectWithTag("Player").transform;
        arbol = animator.gameObject.GetComponent<ArbolCont>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        arbol.Girar(player.transform.position);
        if (animator.GetFloat("Distancia") > 2)
        {
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, player.position, velocidadMovimiento * Time.deltaTime);
        }
        else
        {
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, player.position, 0 * Time.deltaTime);
            animator.SetTrigger("Atacar");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
