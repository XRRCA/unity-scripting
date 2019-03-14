unity-scripting
====

A gentle intro to scripting in Unity

# Goals

+ Overview of programming concepts.
+ Practice making scripts to control and effect things in Unity
+ Introduce a set of existing API functions for GameObject, movement, maths, and event triggering. Use the Physics and Interaction workshop to go deeper.
+ Start to evaluate what you know, need to know and need help with.

# Contents

+ [The Language of Code](#the-language-of-code)
+ [Models and architecture](#models-and-architecture)
+ [Practical](#practical)
+ [Tactics](#tactics)

----
# The Language of Code

## The Basics of Programming with C#

We ignore *Unity* for a minute to set our minds on what all the words and terminology is, this can help you [Google](https://lmgtfy.com/) stuff later when you need help.

### Variables

Stolen from [here](https://www.codingforart.com/processing-section-3/).

Variables give us the power to vary our programs creatively.
Variables store information (data) that your computer uses in flexible ways.

#### Types of basic variables
The type of variable must be specified in the program so the computer can actually use it.

*Integer Variables*

These are variables that hold whole numbers (no fractions, no decimals).
+ Example Values: -2,-1,0,1,2,3
+ The code for declaring an integer variable: ```int```

*Float and Double Variables*

These are variables that hold decimal numbers (fractions, not whole numbers). The name “float” comes from thinking of these decimal numbers as having “floating point values". "Double" comes from being a double precision version of a "float".
+ Example Float Values: 4.3f, 7.9999f, 0.876764f, -10.98f; note the use of "f" at the end of the number.
+ The code for declaring a float variable: ```float```
+ Example Double Values: 4.3, 7.9999, 0.876764, -10.98; Look no f!
+ The code for declaring a double variable: ```double```

*Character Variables*

These are variables that hold letters, letters are enclosed by single quotes. You may use variable integers to create an interactive program that responds when certain keys are pressed.

+ Example Values: ‘c’,’t’,’a’

+ The code for declaring a character variable: `char`

*String Variables*

These are variables that an array of letters, enclosed by double quotes.

+ Example Values: "finger","address","elocution"

+ The code for declaring a string variable: `string`

*Boolean Variables*

These are variables that hold the value of either true or false.

+ Examples (only two options): true, false

+ The code for declaring a boolean variable: `boolean`

**Key points**

Variables must declare:

1. **type**

2. **name**

3. **value**

...so computer to use them.

```csharp
// Type Name = Value;
int myPinNumber = 1234;
float timeToMakeDecision = 495.5f;
bool tomIsALiar = true;
bool isFalse, isNotTrue; // Un valued default to false;
int thisIsZero;
float thisIsAlsoZero;
string coreLifeSkill = "flattery";
```
#### What to do with variables?

As a simple case variables can be used like algebra variables

```csharp
int dob = 1984;
int year = 2019;
int age = year - dob;
```

### Maths Operators

Maths ones include

+ addition `+`, subtraction `-`
+ multiplication `*`, division `/`
+ remainder `%`

[Full list here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/operators), cover more as topics arise.

### Classes

**Classes & objects** - a class is a collection of variables and methods that can be reused eg

```csharp
// Simple car class
public class Car
{ // <- Blocks of code are enclosed by curly brackets: { }
    String name;
    float maxSpeed;

    // Class constructor, stuff it does when it gets made
    public Car()
    {
         name = "Tina";
         maxSpeed = 30.0f;
    }
}

```

Objects are instances of classes created when you run the program.

### Method Signatures

*class, Public/private, methods and returns*

In programming, the instructions we specify start with how different variables and methods are available to other parts of the application/game/code.

Methods are declared in a `class` or `struct` by specifying the access level such as `public` or `private`, optional modifiers such as `abstract` or `sealed`, the return value, the name of the method, and any method parameters. These parts together are the signature of the method.

A **Method** is a code block that contains a series of statements. In C#, every executed instruction is performed in the context of a method.

**Method Parameters**  are enclosed in parentheses and are separated by commas. Empty parentheses indicate that the method requires no parameters.

**Access Level** indicates how other classes and commands can interact with a class. For instance, ```public``` means another object in the app can access it. Other types include `private`, `protected`. More on this in the context of Unity later.

<!-- ```csharp
public class Car
{ // <- Blocks of code are enclosed by curly brackets: { }
    String name; // <- Private by default
    float maxSpeed;
    public float currentSpeed = 0f; // Other things can change this

    public Car()
    {
         name = "Tina";
         maxSpeed = 30.0f;
    }
}

```
```csharp
abstract class Motorcycle
{
    // Anyone can call this.
    public void StartEngine() {/* Method statements here */ }

    // Only derived classes can call this.
    protected void AddPetrol(int gallons) { /* Method statements here */ }

    // Derived classes can override the base class implementation.
    public virtual int Drive(int miles, int speed) { /* Method statements here */ return 1; }

    // Derived classes must implement this.
    public abstract double GetTopSpeed();
}
```
```csharp
class TestMotorcycle : Motorcycle
{

    public override double GetTopSpeed()
    {
        return 108.4;
    }

    static void Main()
    {

        TestMotorcycle moto = new TestMotorcycle();

        moto.StartEngine();
        moto.AddPetrol(15);
        moto.Drive(5, 20);
        double speed = moto.GetTopSpeed();
        Console.WriteLine("My top speed is {0}", speed);
    }
}
``` -->

### Logic

#### Conditionals

Kitties have whiskers –> `true`

17 is smaller than 16 –> `false`

10 equals 10 –> `true`

#### Boolean Operators

+ `>` greater than
+ `<` less than
+ `==` equal to
+ `!=` not equal to
+ `>=` greater than or equal to
+ `<=` less than or equal to

Language assumes left to right.

**Important Key Note!**

If you see:

```if (x == y) { // you are asking is x equivalent to y:```

But, if you see:

```x = y ; // you are stating that set x is equal to set y```

#### Logical operators

Yes, moar symbols!

+ `&&`  AND
+ `||`  OR
+ `!` NOT

#### Conditional Statements

`if` statements allow flow control.

What value is the `bool`?

```csharp
int x = 9;
bool answer = ((x < 10) && ( x > 5)) || ((x > 20) && (x < 25));
```

```csharp
int x = 9;
bool answer;
bool partA;
bool partB;
if(x < 10){
    if( x > 5){
        partA = true;
    }
}

if(x > 20){
    if( x < 25){
        partB = true;
    }
}

if(partA || partB) answer = true;

// See why the top one is better? But while you learn, do it the long way.
```

Combined **if, else, elseif** statements allow more flow control based on what is being evaluated.

```csharp
int t = 0;
int maxTime = 30;
string status = "start";

while( t < maxTime ){
    if( x < 5 )
    {
        status = "counting, less than 5";
        t++;
    }
    else if (x >= 5 && x < 25 )
    {
        status = "counting, between 5 and 25";
        t = t + 1;
    }
    else
    {
        status = "counting, between 25 and 30";
        t += 1;
    }
}
status = "counting complete";
```

#### Loops

Though I snuck one in before, loops such as `while` and `for` allow sets of statements to be evaluated multiple times, until a certain condition is met.

```csharp
for (initializer; condition; iterator)
    body
```

```csharp
int count = 0;
for (int i = 0; i < 5; i++)
{
    count = i;
}
```

### Arrays

The previous example is kind of pointless, a main reason to use for loops is to iterate Arrays. Arrays are lists of variables stored in one instance.

```csharp
int[] numbers = new int[]{3,4,5};
int modifier = 2;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= modifier;
}

// numbers now equal 6, 8, 10
```

----

# Models and architecture

I recommend learning each of these in this order!

## Procedural programming

Creative coding platforms like Processing provide good examples of this format of programming. Key point, you provide instructions one by one in order, this is an **algorithm**.

```java
//////////////////////////////////////
// DRAWING A TRIANGLE IN PROCESSING //
//////////////////////////////////////
void setup()
{
  size(100,100);
  stroke(255);
  strokeWeight(2);
}

void draw()
{
  background(0);

  line(width/2,5,width-5,height-5);
  line(width-5,height-5,5,height-5);
  line(5,height-5,width/2, 5);
}
```

This sort of serial commands is still how unity works but instead of all in one script this process happens across all the GameObjects in your scene.

## Object oriented programming

OOP is a massive topic, broadly it is the process of making abstractions about groups of procedural commands that can be reused.
This includes grouping bits of functionality into a **class** with **methods** (also known as functions)

```java
///////////////////////////////
// TRIANGLE EXAMPLE AS CLASS //
///////////////////////////////
// Declare variables, shorthand way
Point2d a, b, c;
Triangle tri;

void setup()
{
  size(100, 100);
  // Set the drawing settings
  stroke(255);
  strokeWeight(2);

  // Set points data by instantiating new objects of the Point2d class
  a = new Point2d (width/2, 5);
  b = new Point2d (width-5, height-5);
  c = new Point2d (5, height-5);
  // Instantiate new object of the triangle class
  tri = new Triangle (a, b, c);
}

void draw()
{
  background(0);
  tri.render();
}

class Point2d
{
  int x, y;
  Point2d(int x, int y)
  {
    this.x = x;
    this.y = y;
  }
}


class Triangle
{
  Point2d a, b, c;

  Triangle(Point2d a, Point2d b, Point2d c)
  {
    this.a = a;
    this.b = b;
    this.c = c;
  }

  void render()
  {
    line(a.x, a.y, b.x, b.y);
    line(b.x, b.y, c.x, c.y);
    line(c.x, c.y, a.x, a.y);
  }
}

```

Abstraction like this allows cleaner code and creation of lots of the same things.

```java
///////////////////////////////
// LOTS OF TRIANGLES EXAMPLE //
///////////////////////////////

// Declare variables, shorthand way
Point2d[] points;
Triangle[] triangles;

int numOfRows = 5;
int numOfCols = 5;
int numOfTris;

void setup()
{
  size(350, 350);
  // Set the drawing settings
  stroke(255);
  strokeWeight(1);

  int widthX = width/numOfCols;
  int widthY = height/numOfRows;
  int widthXhalf = widthX/2;

  numOfTris = numOfRows * numOfCols;
  points = new Point2d[numOfTris * 3];
  triangles = new Triangle[numOfTris];

  int i = 0, j = 0;
  for (int y = 0; y < numOfCols*widthY; y += widthY) {
    for (int x = widthXhalf; x < numOfRows*widthX; x += widthX, i++, j+=3) {

      // Set points data by instantiating new objects of the Point2d class
      points[j] = new Point2d (x-widthXhalf, y);
      points[j + 1] = new Point2d (x+widthXhalf, y);
      points[j + 2] = new Point2d (x, y+widthY);
      // Instantiate new object of the triangle class
      triangles[i] = new Triangle (points[j], points[j + 1], points[j + 2]);
    }
  }
}

void draw()
{
  background(0);

  for (int i = 0; i < numOfTris; i++)
  {
    triangles[i].render();
  }
}

```

Once the principles of OOP are understood you can achieve quite a large level of complexity in a program.

``` java
////////////////////////
// MOVE THE TRIANGLES //
////////////////////////

// Declare variables, shorthand way
Point2d[] points;
Triangle[] triangles;

int numOfRows = 5;
int numOfCols = 5;
int numOfTris;

void setup()
{
  size(350, 350);
  // Set the drawing settings
  stroke(255);
  strokeWeight(1);

  int widthX = width/numOfCols;
  int widthY = height/numOfRows;
  int widthXhalf = widthX/2;

  numOfTris = numOfRows * numOfCols;
  points = new Point2d[numOfTris * 3];
  triangles = new Triangle[numOfTris];

  // You can make for loops quite detailed by using multiple counters
  for (int i = 0, j = 0, y = 0; y < numOfCols*widthY; y += widthY) {
    for (int x = widthXhalf; x < numOfRows*widthX; x += widthX, i++, j+=3) {

      // Set points data by instantiating new objects of the Point2d class
      points[j] = new Point2d (x-widthXhalf, y);
      points[j + 1] = new Point2d (x+widthXhalf, y);
      points[j + 2] = new Point2d (x, y+widthY);
      // Instantiate new object of the triangle class
      triangles[i] = new Triangle (points[j], points[j + 1], points[j + 2]);
    }
  }
}

void draw()
{
  background(0);

  int index = (int)random(0, points.length);
  if (random(0, 100) > 50)
  {
    points[index].x++;// = (int)random(0, width);
    points[index].y++;// = (int)random(0, height);
  }
  else
  {
    points[index].x--;// = (int)random(0, width);
    points[index].y--;// = (int)random(0, height);
  }
  if (points[index].x > width) points[index].x = width;
  else if (points[index].x < 0) points[index].x = 0;

  if (points[index].y > height) points[index].y = height;
  else if (points[index].y < 0) points[index].y = 0;

  for (int i = 0; i < numOfTris; i++)
  {
    triangles[i].render();
  }
}
```

But! OOP introduces often dogmatic links and hierarchies, historically, Game developers found aspects of OOP too constraining and inefficient for the types of systems they needed to make.

## Entity Component System architecture

In steps ECS as a partial solution to the issues of OOP for game dev.

### Pure ECS

In Pure ECS is programs are made up of

+ entities, things that have components
+ components, bits of data
+ systems, things that act on entities with certain components

The key idea is that you decouple things from their data and the behaviours that do stuff to things

```
PURE ECS EXAMPLE
init() {
  movingSystem = new MovingSystem()
  entity = new Entity()
  entity.add(new Position(), new Velocity())
}

update() {
  movingSystem.update()
}

```

If you are interested in this approach, check out [Entitas](link)

### Unity ECS

Maybe acknowledging that pure ECS inhibits the doing of some basic things, Unity developed a hybrid architecture. It is somewhere between OOP and ECS.
All components in Unity inherit from `MonoBehaviour`, this gives them access to lots of functionality and a overall strucutre.

#### Scripts as Behaviour components

Each Component in the editor on an GameObject is a collection of instructions to give and object properties or behaviours.

### Warning on wording

unity is developing a update to its architecture to improve performance, these are titled "Pure ECS" and "Hybrid ECS". These are unstable for your project work, and are quite complicated to get your head around.

## Summary

Despite having very different appearances, all these models and architectures are the same. It is the level of abstraction that changes.

**Key points**

+ Code must flow in order.
+ Any software is a flow in a series of events.
+ Things can be set-up once, done all the time, or reactively.
+ Programs use input and adjust behaviour based on instructions.

----
# Practical
## Basics
### Creating scripts

Create in the editor either in assets or on a GameObject.

### Variables and Functions

See script VariablesAndFunctions.cs

### Conventions and Syntax

Syntax is the strucutre of the language. The are heirarchical, like an address.

+ Curly brackets - contains instructions
+ Semi-colons - end statements
+ Indentations - used for readabiliy
+ Comments - single line use double slash, multiline use slash star convention
+ If Statements - make decisions based on data
+ Loops - controlling iteration through things and processes.
+ Scope and Access Modifiers - area where variables can be used. Local to classes and functions. Public and private access modifiers is keyword used when declaring variables.

### How Unity works

```
/////////////////////////////////////////////////
// CHECK UNITY FUNCTION OVERVIEW SCRIPT FOLDER //
/////////////////////////////////////////////////

OrderOfExecution.cs - How things happen at different times.
PublicPrivateExample.cs - How to make things visible in the editor.
ErrorExample.cs - Seeing errors in the console.

```

## Making things

+ Instantiate - ways to populate a scene at runtime
+ Co-routines - doing a process with time gaps
+ Destroy - removing GameObjects after a time period
+ Using Input - using key commands

## Changing things

+ Accessing components - GetComponent, GetComponentInChildren, GetComponentInParent e.g. `Rigidbody rb = GetComponent<Rigidbody>();`
+ Enabling and disabling components
+ Activating and deactivating GameObjects
+ Changing colors on materials, short intro to Color Lerp-ing
+ Using the webcam to view yourself

## Moving things

+ Translate - move something in a direction over time.
+ LookAt - make rotations face the directions of targets, in two ways.

## Interacting with things

+ MouseDown - clicking things in the screen space
+ Raycasting - shooting lasers to hit things in space
+ HitEvent - moving the process of object effects on the objects themselves

----

# Tactics

## Don't reinvent the wheel, for now - get API awareness

The stuff in the practical is just sratching the surface of all the functions that Unity give you for free.

The big part is mapping what you want to the language of the field, game development.

## Fake it till you make it, how to copy paste code

You need to develop ways of looking at exisiting resources and adapting them.

Good code should make this easy.

But remember all of other peoples code was made for their purpose, not maybe your exact idea. 
You have to remember what you want to achieve.

## Coding mindset

Breaking down "problems" into things you can describe and then apply logic to.

Looking for places where you can aggregate behaviours to allow manageable complexity.

<!-- **DO** Terminal>python>>>
```python
import this
``` -->
### Find a language to think with, Scripting is just targeted problem solving

At the beginning you will have to learn how to map your ideas onto maths and programming
