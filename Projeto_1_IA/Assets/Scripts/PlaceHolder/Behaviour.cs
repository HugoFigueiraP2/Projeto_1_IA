using LibGameAI.DecisionTrees;
using UnityEngine;

public class Behaviour : MonoBehaviour
{
    //Speed of AI agent movement
    [SerializeField]
    [Range(0f, 20f)]
    private float speed = 5f;

    //IA Agent Status
    private int health = 10;
    private int food = 10;
    private int stamina = 10;

    //The root of the decision tree
    private IDecisionTreeNode root;

    private void Awake()
    {
        
    }

    //Create decision tree
    protected override void Start()
    {
        //Call base class Start()
        base.Start();

        //Create the leaf actions
        IDecisionTreeNode InDanger     = new ActionNode(InDangerAction);
        IDecisionTreeNode Tired        = new ActionNode(TiredAction);
        IDecisionTreeNode Hungry       = new ActionNode(HungrydAction);
        IDecisionTreeNode Normal       = new ActionNode(NormalAction);

        RandomDecisionBehaviour rdb = new RandomDecisionBehaviour(
            () = > )

        root = new DecisionNodeNode(InDanger, Tired, Hungry, Normal)

        //Create random agent status






    }


    //Update is called once per frame
    private void Update()
    {
        ActionNode actionNode = root.MakeDecision() as ActionNode;
        actionNode.Execute();
    }

    //Check if AI_Agent is in danger
    private bool InDangerAction()
    {
        //Pseudo-code: If (Bomb == true), run to exit zone
        return true;
    }
    
    //Check if AI_Agent is Tired
    private void Tired()
    {
        if (stamina <= 2)
        {
            // go to waypoint (GreenZone)
            NextWaypoint();
        }

        MoveTowardsTarget(CurrentWaypoint);
    }

    //Check if AI_Agent is Hungry
    private void Hungry()
    {
        if (food <= 2)
        {
            // go to waypoint (Bar)
            NextWaypoint();
        }

        MoveTowardsTarget(CurrentWaypoint);
    }

    private void Normal()
    {
        //go to waypoint (Stage)
        MoveTowardsTarget(CurrentWaypoint);
    }

    MoveTowardsTarget(CurrentWaypoint);








   
}
