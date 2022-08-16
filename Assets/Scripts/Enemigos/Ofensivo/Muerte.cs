using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : StateMachineBehaviour
{
    public int experiencia = 0;
    public GameObject[] drops = null;
    private GameObject salida;
    public bool jefe = true;
    public string njefe;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (jefe)
        {
            salida = GameObject.FindGameObjectWithTag("Salida");
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        if(drops != null)
        {
           for(int i = 0; i < drops.Length; i++)
            {
                GameObject textOb = Instantiate(drops[i], animator.gameObject.transform.position + Random.onUnitSphere, Quaternion.identity);
                if (salida != null && jefe)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<ComprobadorMision>().MisionTerminada(njefe);
                    salida.GetComponent<SalidaJefes>().ActivarSalida();
                }

            }

        }
       
        GameObject.FindGameObjectWithTag("Player").GetComponent<Experiencia>().GanarExperiencia(experiencia);
        animator.gameObject.SetActive(false);
    }

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
