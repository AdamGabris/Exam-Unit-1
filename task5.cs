#region Task 5


bool nextCellOpen;
bool currentCellVisited;
bool previousCellVisited;
int width = 16;
int height = 15;
int currentCellX = 0;
int currentCellY = 0;

int[,] cellVisitCount = new int[height, width];

while (!AtGoal())
{
    nextCellOpen = Peek();
    currentCellVisited = cellVisitCount[currentCellY, currentCellX] > 0;
    previousCellVisited = PeekBack();

    if (nextCellOpen && !currentCellVisited)
    {
        Move();
        currentCellX++;
        currentCellY++;
        cellVisitCount[currentCellY, currentCellX]++;
        nextCellOpen = Peek();

    }
    else if (!nextCellOpen && previousCellVisited)
    {
        MoveBackward();
        currentCellX--;
        currentCellY--;
        cellVisitCount[currentCellY, currentCellX]++;
        nextCellOpen = Peek();

    }
    else
    {
        int nextDirection = ChooseNextDirection();
        TurnToDirection(nextDirection);
        if (nextCellOpen)
        {
            Move();
            currentCellX++;
            currentCellY++;
            cellVisitCount[currentCellY, currentCellX]++;
            nextCellOpen = Peek();

        }
        else
        {
            MoveBackward();
            currentCellX--;
            currentCellY--;
            cellVisitCount[currentCellY, currentCellX]++;
            nextCellOpen = Peek();

        }
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
    return true;
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true;
}

bool PeekBack()
{
    // Returns true if the previous cell has been visited, otherwise false.
    return true;
}

void MoveBackward()
{
    Turn();
    Turn();
    Move();
    // Moves the car 1 cell backwards. 
}
int ChooseNextDirection()
{
    // Check all possible directions from the current cell and returns the one with the lowest visit count
    return 0;
}

void TurnToDirection(int direction)
{
    Turn() * direction;
    // Turns the car to the specified direction
}

#endregion


#region References

// I tried implementing Tremaux's algorithm of solving mazes.
// I followed the explanation from these two sources: https://kidscodecs.com/maze-solving-algorithms/, and https://en.wikipedia.org/wiki/Maze-solving_algorithm
// and I also used this video as a reference: https://www.youtube.com/watch?v=rop0W4QDOUI
// I am not quite sure how to fully implement the algorithm, so I tried to do it in a way that made sense to me.

#endregion