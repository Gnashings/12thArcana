using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWanderState : HeroBaseState
{
    bool moveRight;
    Vector3 rightWP;
    Vector3 leftWP;
    Vector3 heroPosX;
    float upperBound;
    float lowerBound;
    float range;
    float temper;
    bool tickTemper;
    public override void EnterState(HeroStateManager heroState)
    {
        //Debug.Log("wondering");

        //set range bounds
        upperBound = 3f;
        lowerBound = 0.05f;

        //set waypoint x value for readibility;
        rightWP = new Vector3(heroState.rightWaypoint.transform.position.x, heroState.transform.position.y, heroState.transform.position.z);
        leftWP = new Vector3(heroState.leftWaypoint.transform.position.x, heroState.transform.position.y, heroState.transform.position.z);

        //generate a random range to wander.
        range = Random.Range(lowerBound, upperBound);

        //reset temper
        temper = 0;

        //set temper to become a little more random
        temper = Random.Range(1, 10);
        heroState.StartCoroutine(Temper());
        heroState.anim.Play("walk_anim");
    }

    public override void UpdateState(HeroStateManager heroState)
    {
        //PATH TO JUMP/DODGE/BLOCK
        if (heroState.aura.jumpDecision)
        {

            heroState.SwitchState(heroState.jumpState);
        }
        if (heroState.aura.dodgeDecision)
        {
            heroState.SwitchState(heroState.dodgeState);
        }
        if(heroState.aura.blockDecision)
        {
            heroState.SwitchState(heroState.blockState);
        }

        //movement
        heroPosX = new Vector3(heroState.transform.position.x, heroState.transform.position.y, heroState.transform.position.z);
        if (moveRight)
        {
            MoveRight(heroState);
        }
        else MoveLeft(heroState);

        //ticking up for ground attack
        if (tickTemper == true)
        {
            heroState.StartCoroutine(Temper());
        }
        else if (temper >= 10f)
        {
            tickTemper = false;
            heroState.SwitchState(heroState.attackState);
        }
    }

    public override void ExitState(HeroStateManager heroState)
    {

    }

    public bool MoveRight(HeroStateManager heroState)
    {
        if (Vector3.Distance(heroPosX, rightWP) > range)
        {
            heroState.transform.position = Vector3.MoveTowards(heroState.transform.position, rightWP, Time.deltaTime * 1f);
            return moveRight = true;
        }
        range = Random.Range(lowerBound, upperBound);
        return moveRight = false;
    }

    public bool MoveLeft(HeroStateManager heroState)
    {
        if (Vector3.Distance(heroPosX, leftWP) > range)
        {
            heroState.transform.position = Vector3.MoveTowards(heroState.transform.position, leftWP, Time.deltaTime * 1f);
            return moveRight = false;
        }
        range = Random.Range(lowerBound, upperBound);
        return moveRight = true;
    }

    IEnumerator Temper()
    {
        tickTemper = false;
        yield return new WaitForSeconds(1f);
        temper++;
        //Debug.Log("TEMPER: " + temper);
        tickTemper = true;
    }
}
