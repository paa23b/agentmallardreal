using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState;
    public PatrolState patrolState;

    public void Initialize()
    {
       patrolState = new PatrolState();
        ChangeState(patrolState);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(activeState != null)
        {
            activeState.Perform();
        } 
    }
    public void ChangeState(BaseState newState)
    {
        // check activeState != null
        if(activeState != null)
        {
            // run a cleanup on activeState
            activeState.Exit();
        }
        // change to a new state
        activeState = newState;

        if(activeState != null )
        {
            // setup a new state
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();
        }
    }
}
