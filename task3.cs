#region Task 1

// Keeping track of the direction, 0 is  up, 1 is right, 2 is down and 3 is left
int direction = 0;

while (!AtGoal())
{
    if (PeekRight())
    {

        Turn();
        direction = (direction + 1) % 4;

        if (Peek())
        {
            Move();
        }
    }
    else if (Peek())
    {
        Move();
    }
    else
    {
        Turn();
        Turn();
        Turn();
        direction = (direction + 3) % 4;
    }
}

Console.WriteLine("Goal reached!");

#endregion

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

bool PeekRight()
{
    int originalDirection = direction;

    Turn();
    direction = (direction + 1) % 4;

    bool result = Peek();

    direction = originalDirection;

    Turn();
    Turn();
    Turn();
    direction = (direction + 3) % 4;

    return result;
}

#endregion