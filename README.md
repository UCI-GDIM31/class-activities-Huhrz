# in-class-activities
## Devlogs
### W1
A video game is like a theater play. The Scene is the stage where everything happens. The GameObjects are the actors on the stage, like characters, props, or lights. The Components are the costumes, skills, and scripts. Without the stage, the story has no place; without the actors, the stage is empty; and without the components, the actors can’t do anything. Together, they make the game come alive.
### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

because the scale of RGB color is from 0.0 to 1.0, it contains decimals.
because the number of bouncing time must be integral.
we must add semicolen after a code line or we must add f after the quantity while changing the float variable.
### W3
the player’s dialogue choice as a string or int, the player’s friendship level with the character as an int or float, and a boolean flag indicating whether the player knows the character’s secret. It should return a string containing the character’s dialogue response.
### W4
Line 5: _moveSpeed is a member variable, and the type is float.
it stores a decimal number that controls how fast the character moves.
Line 22: This line declares a local variable named translation, and the type is float.
It calls the method Input.GetAxis("Vertical"), which returns a decimal value between -1 and 1 depending on the player’s keyboard input The method parameters are the string "Vertical", telling Unity which input axis to read.
The result is multiplied by _moveSpeed and Time.deltaTime to make the movement smooth and frame rate–independent.
Line 25: This line is calling a method named Translate() from the Transform Component attached to the GameObject. The method parameters are three floats: 0, 0, and translation, representing movement along the x, y, and z axes. This moves the GameObject forward or backward based on the translation value calculated above.

1.I added Rigidbody components to both the Cat and the SoccerBall, because those objects need to move and respond to physics. The Goal didn’t need a Rigidbody since it stays still. We also checked Is Trigger on the Goal’s BoxCollider, so the ball could pass through it and still detect when it scored.
2.The first time I tested the game, the ball didn’t detect the goal correctly because the OnTriggerEnter method wasn’t being called. I realized the collider name had the wrong capitalization .After fixing that and adjusting the collider sizes, everything worked.
### W5
How does GetComponent<>() actually find the specific component on a GameObject — does it search through all components every time, or is it stored in memory after the first call?

GetComponent<>() searches through all the components attached to the GameObject each time it’s called. That means it’s a bit slow if used repeatedly in Update(). To make it faster, developers usually call it once in Start() or Awake(), store the result in a variable, and then reuse that variable later.

Plan: Deer has component of NavMeshAgent use to find way in terrain, use Getcomponent<> to set NavmeshAgent to NevMeshAgent agent variable so that i can use it on Start() then use agent.Setdesintation to set a destination for deer which is transform target variable set his position to Deer's destination to make it move towards to the cat.
### W6
https://docs.google.com/document/d/1I9v9DLgH_h1Npt-SvcE6Rrcdn8rclMwmf5H-zmU4f14/edit?usp=sharing
General C# coding (Week 2) & W3 schools tutorials;
{} If statements, for loops, methods
Variables
Class (Week 2)
int
float
bool
String
Component
NavMesh
Rigidbody
Collider
Method
if(), else, else if() (Week2) 
return()
Loops =>(minigame #5) (Week 6 pre learning)
Arrays (Week 6 pre learning)
Operator (week2)
&&(and)
|| (or)
1.Member variables
A float speed  → how fast the bat moves.
A Transform target → the Cat/player to chase.
A bool isChasing → remembers if the bat should move or not.
2.Update method
In Update(), check: if (isChasing && target != null)
If true, move the bat toward target.position with Vector3.MoveTowards using speed * Time.deltaTime.
3.Control methods
public void StartChasing() → set isChasing = true;
public void StopChasing() → set isChasing = false;
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 