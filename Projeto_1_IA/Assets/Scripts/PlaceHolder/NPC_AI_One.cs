using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using LibGameAI.DecisionTrees;

public class NPC_AI_One : MonoBehaviour
{
    // Destiny of the AI Agents depending the actual status
    [SerializeField] private Transform normal_destiny;
    [SerializeField] private Transform bar_destiny;
    [SerializeField] private Transform greenZone_destiny;

    //AI Agent Status
    private int health = 10;
    private int food = 10;
    private int stamina = 10;

    //Speed of AI agent movement
    [SerializeField]
    [Range(0f, 20f)]
    private float speed = 5f;

    //Decision Tree root
    private IDecisionTreeNode root;

    private NavMeshAgent npc;
    private int rnd;

    // Start is called before the first frame update
    void Start()
    {
        npc = GetComponent<NavMeshAgent>();
        npc.SetDestination(normal_destiny.position);

        //Create the leaf actions
        IDecisionTreeNode InDanger = new ActionNode(InDangerAction);
        IDecisionTreeNode Tired = new ActionNode(TiredAction);
        IDecisionTreeNode Hungry = new ActionNode(HungryAction);
        IDecisionTreeNode Normal = new ActionNode(NormalAction);

        //RandomDecisionBehaviour rdb = new RandomDecisionBehaviour(
           // () = > )

        root = new DecisionNode(InDanger, Tired, Hungry, Normal);
    }

    //Update is called once per frame
    private void Update()
    {
        ActionNode actionNode = root.MakeDecision() as ActionNode;
        actionNode.Execute();
    }

    //Check if AI_Agent is Tired
    private void TiredAction()
    {
        if (stamina <= 2)
        {
            // go to waypoint (GreenZone)
            NextWaypoint();
        }

        MoveTowardsTarget(CurrentWaypoint);
    }

    //Check if AI_Agent is Hungry
    private void HungryAction()
    {
        if (food <= 2)
        {
            // go to waypoint (Bar)
            NextWaypoint();
        }

        MoveTowardsTarget(CurrentWaypoint);
    }

    //Check if AI_Agent is normal
    private void NormalAction()
    {
        //go to waypoint (Stage)
        MoveTowardsTarget(CurrentWaypoint);
    }

    //Check if AI_Agent is in danger
    private void InDangerAction()
    {
        //if agent in danger, go to exit (Stage)
        MoveTowardsTarget(CurrentWaypoint);
    }

    MoveTowardsTarget(CurrentWaypoint);

    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Destiny")
        {
            rnd = Random.Range(0, 5);
            Invoke("Destination", rnd);
        }
    }

    private void Destination()
    {
        npc.SetDestination(normal_destiny.position);
    }
}















