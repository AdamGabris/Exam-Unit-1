#region Task 3

bool nextCellOpen;
bool previousCellVisited;
while (!AtGoal())
{
    nextCellOpen = Peek();
    previousCellVisited = PeekBack();
    if (nextCellOpen && !previousCellVisited)
    {
        Move();
    }
    else
    {
        Turn();
    }

    if (AtGoal())
    {
        Console.WriteLine("Goal reached!");
        break;
    }
}



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

bool PeekBack()
{
    // Returns true if the previous cell has been visited, otherwise false.
    return true; //
}

#endregion