using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;     // Unity Machine Learning Agents library

public class PenguinAgent : Agent
{
#region PUBLIC VARIABLES
    [Tooltip("How fast the agent moves forward")]
    public float moveSpeed = 5f;

    [Tooltip("How fast the agent turns")]
    public float turnSpeed = 180f;

    [Tooltip("Prefab of the heart that appears when the baby is fed")]
    public GameObject heartPrefab;

    [Tooltip("Prefab of the regurgitated fish that appears when the baby is fed")]
    public GameObject regurgitatedFishPrefab;
#endregion

#region PRIVATE VARIABLES
    private PenguinArea penguinArea;
    private PenguinAcademy penguinAcademy;
    new private Rigidbody rigidbody;
    private GameObject baby;
    private bool isFull; // If true, penguin has a full stomach
    private float feedRadius = 0f;
#endregion


    /// <summary>
    /// Initial setup, called when the agent is enabled
    /// </summary>
    public override void InitializeAgent()
    {
        base.InitializeAgent();
        penguinArea = GetComponentInParent<PenguinArea>();
        penguinAcademy = FindObjectOfType<PenguinAcademy>();
        baby = penguinArea.penguinBaby;
        rigidbody = GetComponent<Rigidbody>();
    }

}
