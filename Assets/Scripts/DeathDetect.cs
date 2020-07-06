using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetect : MonoBehaviour
{
    /// <summary>
    /// The associated agent.
    /// This will be set by the agent script on Initialization.
    /// Don't need to manually set.
    /// </summary>
    [HideInInspector]
    public MonkeyBallAgent agent;

    void FixedUpdate() { 

        if (agent.gameObject.transform.position.y < gameObject.transform.position.y)
        {
            agent.Death();
        }
    }
}
