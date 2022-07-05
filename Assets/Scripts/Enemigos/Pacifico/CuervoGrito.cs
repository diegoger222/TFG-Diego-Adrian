using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuervoGrito : StateMachineBehaviour
{

    [SerializeField] public GameObject caw;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector3 pos;

        if (animator.gameObject.GetComponent<SpriteRenderer>().flipX)
        {
            pos = new Vector3(animator.transform.position.x - 0.6f, animator.transform.position.y + 0.4f, animator.transform.position.z);
            caw.GetComponent<MovimientoCaw>().dere = false;
        }
        else
        {
            pos = new Vector3(animator.transform.position.x + 0.6f, animator.transform.position.y + 0.4f, animator.transform.position.z);
            caw.GetComponent<MovimientoCaw>().dere = true;
        }
        GameObject textOb = Instantiate(caw, pos , Quaternion.identity);
        Destroy(textOb, 2);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
