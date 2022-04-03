using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Triggered when a decision to dodge has been made.
/// also disables the heros aura -THIS MIGHT CHANGE-
/// </summary>
public class HeroDodgeState : HeroBaseState
{
    bool dodgeComplete;
    bool dodgeRight;
    Vector3 rightWP;
    Vector3 leftWP;
    Vector3 heroPosX;
    //float upperBound;
    //float lowerBound;
    float dodgeBuffer;
    float speed;
    public override void EnterState(HeroStateManager heroState)
    {
        heroState.DumpAuraMemory();
        

        //set range bounds
        //upperBound = 3f;
        //lowerBound = 0.05f;

        //set waypoint x value for readibility;
        rightWP = new Vector3(heroState.dodgeRightWaypoint.transform.position.x, heroState.transform.position.y, heroState.transform.position.z);
        leftWP = new Vector3(heroState.dodgeLeftWaypoint.transform.position.x, heroState.transform.position.y, heroState.transform.position.z);
        heroPosX = new Vector3(heroState.transform.position.x, heroState.transform.position.y, heroState.transform.position.z);

        //generate a random range to wander.
        dodgeBuffer = 0.15f;

        speed = 4f;
        //Debug.Log("right WP Distance: " + Vector3.Distance(heroPosX, rightWP));
        //Debug.Log("left WP Distance: " + Vector3.Distance(heroPosX, leftWP));

        if (Vector3.Distance(heroPosX, rightWP) > Vector3.Distance(heroPosX, leftWP))
        {
            dodgeRight = true;
        }
        else
            dodgeRight = false;

        //Debug.Log("dodging right: " + dodgeRight);
    }

    public override void ExitState(HeroStateManager heroState)
    {
        dodgeComplete = false;
        heroState.EnableAura();
        //Debug.Log("DODGE COMPLETE");
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        heroPosX = heroState.transform.position;

        if (dodgeComplete == false)
        {
            if (dodgeRight)
            {
                MoveRight(heroState);
            }
            else
                MoveLeft(heroState);
        }
        else
        {
            heroState.SwitchState(heroState.idleState);
        }


    }

    public bool MoveRight(HeroStateManager heroState)
    {
        if (Vector3.Distance(heroPosX, rightWP) > dodgeBuffer)
        {
            heroState.transform.position = Vector3.MoveTowards(heroState.transform.position, rightWP, Time.deltaTime * speed);
            return dodgeComplete = false;
        }
        //dodgeBuffer = Random.Range(lowerBound, upperBound);
        return dodgeComplete = true;
    }

    public bool MoveLeft(HeroStateManager heroState)
    {
        if (Vector3.Distance(heroPosX, leftWP) > dodgeBuffer)
        {
            heroState.transform.position = Vector3.MoveTowards(heroState.transform.position, leftWP, Time.deltaTime * speed);
            return dodgeComplete = false;
        }
        //dodgeBuffer = Random.Range(lowerBound, upperBound);
        return dodgeComplete = true;
    }
}
